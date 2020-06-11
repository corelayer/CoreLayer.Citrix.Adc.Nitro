using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbmonitorUpdateRequestConfigurationValidationTestData))]
        public void LbmonitorUpdateRequestConfigurationValidationTest(LbmonitorUpdateRequestConfiguration configuration,
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

    public class LbmonitorUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbmonitorUpdateRequestConfiguration(new LbmonitorUpdateRequestDataRoot(new LbmonitorUpdateHttpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"RequestContent", "{\"lbmonitor\":[{\"type\":\"HTTP\",\"monitorname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LbmonitorUpdateRequestConfiguration(
                    new LbmonitorUpdateRequestDataRoot(new dynamic[]
                    {
                        new LbmonitorUpdateTcpRequestData("test")
                        {
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"RequestContent", "{\"lbmonitor\":[{\"type\":\"TCP\",\"monitorname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LbmonitorUpdateRequestConfiguration(new LbmonitorUpdateRequestDataRoot(new LbmonitorUpdateHttpInlineRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"RequestContent", "{\"lbmonitor\":[{\"type\":\"HTTP-INLINE\",\"monitorname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LbmonitorUpdateRequestConfiguration(new LbmonitorUpdateRequestDataRoot(new LbmonitorUpdateHttpEcvRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"RequestContent", "{\"lbmonitor\":[{\"type\":\"HTTP-ECV\",\"monitorname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}