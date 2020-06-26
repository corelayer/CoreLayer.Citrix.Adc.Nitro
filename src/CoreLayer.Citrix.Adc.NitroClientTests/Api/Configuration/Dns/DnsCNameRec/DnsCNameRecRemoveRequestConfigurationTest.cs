using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsCNameRecRemoveRequestConfigurationValidationTestData))]
        public void DnsCNameRecRemoveRequestConfigurationValidationTest(
            DnsCNameRecRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class DnsCNameRecRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsCNameRecRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnscnamerec"},
                    {"RequestUri", "/nitro/v1/config/dnscnamerec"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new DnsCNameRecRemoveRequestConfiguration()
                {
                    Options = new DnsCNameRecRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name","testName"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnscnamerec"},
                    {"RequestUri", "/nitro/v1/config/dnscnamerec?args=name:testName"},
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