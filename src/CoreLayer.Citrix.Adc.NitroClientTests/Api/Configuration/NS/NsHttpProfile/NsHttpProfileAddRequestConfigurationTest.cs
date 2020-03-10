using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsHttpProfileAddRequestConfigurationValidationTestData))]
        public void NsHttpProfileAddRequestConfigurationValidationTest(
            NsHttpProfileAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class NsHttpProfileAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsHttpProfileAddRequestConfiguration(new NsHttpProfileAddRequestDataRoot(new NsHttpProfileAddRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile"},
                    {"RequestContent", "{\"nshttpprofile\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new NsHttpProfileAddRequestConfiguration(new NsHttpProfileAddRequestDataRoot(new NsHttpProfileAddRequestData("test")
                {
                    WebSocket = "testWS"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile"},
                    {"RequestContent", "{\"nshttpprofile\":[{\"name\":\"test\",\"websocket\":\"testWS\"}]}"},
                    {"Options", ""}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}