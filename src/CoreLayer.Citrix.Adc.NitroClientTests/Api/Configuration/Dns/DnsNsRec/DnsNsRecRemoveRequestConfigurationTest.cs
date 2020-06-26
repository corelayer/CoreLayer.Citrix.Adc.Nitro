using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsNsRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsNsRec
{
    public class DnsNsRecRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsNsRecRemoveRequestConfigurationValidationTestData))]
        public void DnsNsRecRemoveRequestConfigurationValidationTest(DnsNsRecRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class DnsNsRecRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsNsRecRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnsnsrec"},
                    {"RequestUri", "/nitro/v1/config/dnsnsrec"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new DnsNsRecRemoveRequestConfiguration()
                {
                    Options = new DnsNsRecRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name","testName"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnsnsrec"},
                    {"RequestUri", "/nitro/v1/config/dnsnsrec?args=name:testName"},
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