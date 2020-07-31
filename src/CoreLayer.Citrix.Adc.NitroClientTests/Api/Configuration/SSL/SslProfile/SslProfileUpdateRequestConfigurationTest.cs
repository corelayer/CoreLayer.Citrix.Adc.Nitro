using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.SSL.SslProfile
{
    public class SslProfileUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SslProfileUpdateRequestConfigurationValidationTestData))]
        public void SslProfileUpdateRequestConfigurationValidationTest(
            SslProfileUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SslProfileUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SslProfileUpdateRequestConfiguration(new SslProfileUpdateRequestDataRoot(new SslProfileUpdateRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/sslprofile"},
                    {"RequestUri", "/nitro/v1/config/sslprofile"},
                    {"RequestContent", "{\"sslprofile\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new SslProfileUpdateRequestConfiguration(new SslProfileUpdateRequestDataRoot(new SslProfileUpdateRequestData("test")
                {
                    EphemeralRsa = "ENABLE"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/sslprofile"},
                    {"RequestUri", "/nitro/v1/config/sslprofile"},
                    {"RequestContent", "{\"sslprofile\":[{\"name\":\"test\",\"ersa\":\"ENABLE\"}]}"},
                    {"Options", ""}
                }
            };         }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}