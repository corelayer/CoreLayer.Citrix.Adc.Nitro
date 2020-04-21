using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileRemoveConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SslCertFileRemoveConfigurationValidationTestData))]
        public void SslCertFileRemoveConfigurationValidationTest(SslCertFileRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SslCertFileRemoveConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SslCertFileRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/sslcertfile"},
                    {"RequestUri", "/nitro/v1/config/sslcertfile"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new SslCertFileRemoveRequestConfiguration()
                {
                    Options = new SslCertFileRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "test"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/sslcertfile"},
                    {"RequestUri", "/nitro/v1/config/sslcertfile?args=name:test"},
                    {"Options", "?args=name:test"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}