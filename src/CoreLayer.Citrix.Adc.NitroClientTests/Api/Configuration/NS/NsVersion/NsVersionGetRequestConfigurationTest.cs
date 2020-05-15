using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsVersion;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsVersion
{
    public class NsVersionGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsVersionGetRequestConfigurationValidationTestData))]
        public void NsTcpProfileGetRequestConfigurationValidationTest(NsVersionGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class NsVersionGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsVersionGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/nsversion"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/nsversion"}
                } 
            };
            yield return new object[]
            {
                new NsVersionGetRequestConfiguration()
                {
                    Options = new NitroRequestArgumentOptions
                    {
                        Arguments = new Dictionary<string, string>
                        {
                            {"installedversion", "true"}
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/nsversion"},
                    {"Method", "GET"},
                    {"Options", "?args=installedversion:true"},
                    {"RequestUri", "/nitro/v1/config/nsversion?args=installedversion:true"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}