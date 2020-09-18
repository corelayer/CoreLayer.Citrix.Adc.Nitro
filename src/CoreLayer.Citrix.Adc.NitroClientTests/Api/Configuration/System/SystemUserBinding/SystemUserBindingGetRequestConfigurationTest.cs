using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserBinding;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemUserBinding
{
    public class SystemUserBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemUserBindingGetRequestConfigurationValidationTestData))]
        public void SystemUserBindingGetRequestConfigurationValidationTest(
            SystemUserBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemUserBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemUserBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/systemuser_binding"},
                    {"Method", "GET"},
                    {"Options", "?bulkbindings=yes"},
                    {"RequestUri", "/nitro/v1/config/systemuser_binding?bulkbindings=yes"}
                } 
            };
            yield return new object[]
            {
                new SystemUserBindingGetRequestConfiguration
                {
                    Options = new SystemUserBindingGetRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/systemuser_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Filter"},
                    {"RequestUri", "/nitro/v1/config/systemuser_binding/resourceName?attrs=Filter"}
                } 
            };
            yield return new object[]
            {
                new SystemUserBindingGetRequestConfiguration
                {
                    Options = new SystemUserBindingGetRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }, 
                        Count = true,
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/systemuser_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?count=yes&attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/systemuser_binding/resourceName?count=yes&attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}