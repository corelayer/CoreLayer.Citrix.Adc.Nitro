using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsTcpProfileGetRequestConfigurationValidationTestData))]
        public void NsTcpProfileGetRequestConfigurationValidationTest(NsTcpProfileGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class NsTcpProfileGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsTcpProfileGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/nstcpprofile"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/nstcpprofile"}
                } 
            };
            yield return new object[]
            {
                new NsTcpProfileGetRequestConfiguration
                {
                    Options = new NsTcpProfileGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/nstcpprofile"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Filter"},
                    {"RequestUri", "/nitro/v1/config/nstcpprofile/resourceName?attrs=Filter"}
                } 
            };
            yield return new object[]
            {
                new NsTcpProfileGetRequestConfiguration
                {
                    Options = new NsTcpProfileGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/nstcpprofile"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?count=yes&attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/nstcpprofile/resourceName?count=yes&attrs=Name"}
                } 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}