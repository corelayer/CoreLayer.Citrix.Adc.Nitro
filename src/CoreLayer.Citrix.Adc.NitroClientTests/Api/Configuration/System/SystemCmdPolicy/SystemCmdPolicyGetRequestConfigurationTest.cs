using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemCmdPolicyGetRequestConfigurationValidationTestData))]
        public void SystemCmdPolicyGetRequestConfigurationValidationTest(
            SystemCmdPolicyGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemCmdPolicyGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemCmdPolicyGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/systemcmdpolicy"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/systemcmdpolicy"}
                } 
            };
            yield return new object[]
            {
                new SystemCmdPolicyGetRequestConfiguration
                {
                    Options = new SystemCmdPolicyGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/systemcmdpolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Filter"},
                    {"RequestUri", "/nitro/v1/config/systemcmdpolicy/resourceName?attrs=Filter"}
                } 
            };
            yield return new object[]
            {
                new SystemCmdPolicyGetRequestConfiguration
                {
                    Options = new SystemCmdPolicyGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/systemcmdpolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?count=yes&attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/systemcmdpolicy/resourceName?count=yes&attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}