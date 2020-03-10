using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.SSL.SslProfile
{
    public class SslProfileRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SslProfileRemoveRequestConfigurationValidationTestData))]
        public void SslProfileRemoveRequestConfigurationValidationTest(
            SslProfileRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class SslProfileRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SslProfileRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/sslprofile"},
                    {"RequestUri", "/nitro/v1/config/sslprofile"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new SslProfileRemoveRequestConfiguration()
                {
                    Options = new SslProfileRemoveRequestOptions("testSslProf")
                    {
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/sslprofile"},
                    {"RequestUri", "/nitro/v1/config/sslprofile/testSslProf"},
                    {"Options", "/testSslProf"},
                }, 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}