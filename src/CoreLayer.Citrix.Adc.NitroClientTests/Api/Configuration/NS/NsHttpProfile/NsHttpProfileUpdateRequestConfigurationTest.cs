using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsHttpProfileUpdateRequestConfigurationValidationTestData))]
        public void NsHttpProfileUpdateRequestConfigurationValidationTest(
            NsHttpProfileUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class NsHttpProfileUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsHttpProfileUpdateRequestConfiguration(new NsHttpProfileUpdateRequestDataRoot(new NsHttpProfileUpdateRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile"},
                    {"RequestContent", "{\"nshttpprofile\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new NsHttpProfileUpdateRequestConfiguration(new NsHttpProfileUpdateRequestDataRoot(new NsHttpProfileUpdateRequestData("test")
                {
                    WebSocket = "testWS"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
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