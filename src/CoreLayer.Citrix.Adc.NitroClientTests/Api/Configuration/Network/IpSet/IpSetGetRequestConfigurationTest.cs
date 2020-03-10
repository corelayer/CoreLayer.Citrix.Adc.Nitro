using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Network.IpSet
{
    public class IpSetGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(IpSetGetRequestConfigurationValidationTestData))]
        public void IpSetGetRequestConfigurationValidationTest(IpSetGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class IpSetGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new IpSetGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/ipset"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/ipset"}
                } 
            };
            yield return new object[]
            {
                new IpSetGetRequestConfiguration
                {
                    Options = new IpSetGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/ipset"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Filter"},
                    {"RequestUri", "/nitro/v1/config/ipset/resourceName?attrs=Filter"}
                } 
            };
            yield return new object[]
            {
                new IpSetGetRequestConfiguration
                {
                    Options = new IpSetGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/ipset"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?count=yes&attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/ipset/resourceName?count=yes&attrs=Name"}
                } 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}