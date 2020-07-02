using System.Collections;
using System.Collections.Generic;
using System.Security;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileImportConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SslCertFileImportConfigurationValidationTestData))]
        public void SslCertFileImportConfigurationValidationTest(SslCertFileImportRequestConfiguration configuration,
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

    public class SslCertFileImportConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SslCertFileImportRequestConfiguration(new SslCertFileImportRequestDataRoot(new SslCertFileImportRequestData(){Name = "test"})),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/sslcertfile"},
                    {"RequestUri", "/nitro/v1/config/sslcertfile?action=Import"},
                    {"RequestContent", "{\"sslcertfile\":[{\"name\":\"test\"}]}"},
                    {"Options", "?action=Import"}
                }
            };
            yield return new object[]
            {
                new SslCertFileImportRequestConfiguration(new SslCertFileImportRequestDataRoot(new SslCertFileImportRequestData()
                {
                    Name = "test",
                    Source = "testSrc"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/sslcertfile"},
                    {"RequestUri", "/nitro/v1/config/sslcertfile?action=Import"},
                    {"RequestContent", "{\"sslcertfile\":[{\"name\":\"test\",\"src\":\"testSrc\"}]}"},
                    {"Options", "?action=Import"}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}