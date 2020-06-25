using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsAddRecRemoveRequestConfigurationValidationTestData))]
        public void DnsAddRecRemoveRequestConfigurationValidationTest(DnsAddRecRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class DnsAddRecRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsAddRecRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnsaddrec"},
                    {"RequestUri", "/nitro/v1/config/dnsaddrec"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new DnsAddRecRemoveRequestConfiguration()
                {
                    Options = new DnsAddRecRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name","testName"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnsaddrec"},
                    {"RequestUri", "/nitro/v1/config/dnsaddrec?args=name:testName"},
                    {"Options", "?args=name:testName"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}