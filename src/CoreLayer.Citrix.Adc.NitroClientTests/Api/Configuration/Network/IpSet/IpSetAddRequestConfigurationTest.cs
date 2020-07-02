using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Network.IpSet
{
    public class IpSetAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(IpSetAddRequestConfigurationValidationTestData))]
        public void IpSetAddRequestConfigurationValidationTest(IpSetAddRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class IpSetAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new IpSetAddRequestConfiguration(new IpSetAddRequestDataRoot(new IpSetAddRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/ipset"},
                    {"RequestUri", "/nitro/v1/config/ipset"},
                    {"RequestContent", "{\"ipset\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new IpSetAddRequestConfiguration(new IpSetAddRequestDataRoot(new IpSetAddRequestData("test")
                {
                    TrafficDomain = 5
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/ipset"},
                    {"RequestUri", "/nitro/v1/config/ipset"},
                    {"RequestContent", "{\"ipset\":[{\"name\":\"test\",\"td\":5}]}"},
                    {"Options", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}