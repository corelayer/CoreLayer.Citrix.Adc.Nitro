using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Network.IpSet
{
    public class IpSetRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(IpSetRemoveRequestConfigurationValidationTestData))]
        public void IpSetRemoveRequestConfigurationValidationTest(IpSetRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class IpSetRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new IpSetRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/ipset"},
                    {"RequestUri", "/nitro/v1/config/ipset"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new IpSetRemoveRequestConfiguration()
                {
                    Options = new IpSetRemoveRequestOptions("testIS")
                    {
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/ipset"},
                    {"RequestUri", "/nitro/v1/config/ipset/testIS"},
                    {"Options", "/testIS"},
                }, 
            };          }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}