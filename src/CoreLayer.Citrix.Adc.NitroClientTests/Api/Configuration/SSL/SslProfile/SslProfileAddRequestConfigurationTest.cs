using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.SSL.SslProfile
{
    public class SslProfileAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SslProfileAddRequestConfigurationValidationTestData))]
        public void SslProfileAddRequestConfigurationValidationTest(SslProfileAddRequestConfiguration configuration,
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
    public class SslProfileAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SslProfileAddRequestConfiguration(new SslProfileAddRequestDataRoot(new SslProfileAddRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/sslprofile"},
                    {"RequestUri", "/nitro/v1/config/sslprofile"},
                    {"RequestContent", "{\"sslprofile\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new SslProfileAddRequestConfiguration(new SslProfileAddRequestDataRoot(new SslProfileAddRequestData("test")
                {
                    SniEnable = "YES"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/sslprofile"},
                    {"RequestUri", "/nitro/v1/config/sslprofile"},
                    {"RequestContent", "{\"sslprofile\":[{\"name\":\"test\",\"snienable\":\"YES\"}]}"},
                    {"Options", ""}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}