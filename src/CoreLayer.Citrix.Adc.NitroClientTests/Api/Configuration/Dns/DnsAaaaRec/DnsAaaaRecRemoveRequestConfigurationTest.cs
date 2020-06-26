using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsAaaaRecRemoveRequestConfigurationValidationTestData))]
        public void DnsAaaaRecRemoveRequestConfigurationValidationTest(
            DnsAaaaRecRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class DnsAaaaRecRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsAaaaRecRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnsaaaarec"},
                    {"RequestUri", "/nitro/v1/config/dnsaaaarec"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new DnsAaaaRecRemoveRequestConfiguration()
                {
                    Options = new DnsAaaaRecRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name","testName"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnsaaaarec"},
                    {"RequestUri", "/nitro/v1/config/dnsaaaarec?args=name:testName"},
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