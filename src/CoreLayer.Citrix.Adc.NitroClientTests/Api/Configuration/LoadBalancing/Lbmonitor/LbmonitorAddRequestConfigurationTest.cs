using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbmonitorAddRequestConfigurationValidationTestData))]
        public void LbmonitorAddRequestConfigurationValidationTest(LbmonitorAddRequestConfiguration configuration,
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
    public class LbmonitorAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbmonitorAddRequestConfiguration(new LbmonitorAddRequestDataRoot(new LbmonitorAddHttpRequestData("testMonitor"))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbmonitor\":[{\"monitorname\":\"testMonitor\",\"type\":\"HTTP\"}]}"}
                }
            };
            yield return new object[]
            {
                new LbmonitorAddRequestConfiguration(new LbmonitorAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbmonitorAddHttpRequestData("testMonitor1"),
                        new LbmonitorAddHttpRequestData("testMonitor2")
                        {
                            Interval = 10,
                            ResponseTimeout = 3,
                            State = "DISABLED"
                        } 
                    })
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbmonitor\":[{\"monitorname\":\"testMonitor1\",\"type\":\"HTTP\"}," +
                                       "{\"monitorname\":\"testMonitor2\",\"type\":\"HTTP\",\"interval\":10,\"resptimeout\":3," +
                                       "\"state\":\"DISABLED\"}]}"}
                } 
            };
            yield return new object[]
            {
                new LbmonitorAddRequestConfiguration(new LbmonitorAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbmonitorAddTcpRequestData("testMonitor1"),
                        new LbmonitorAddTcpRequestData("testMonitor2")
                        {
                            Secure = "YES",
                            State = "DISABLED"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbmonitor\":[{\"monitorname\":\"testMonitor1\",\"type\":\"TCP\"}," +
                                       "{\"monitorname\":\"testMonitor2\",\"type\":\"TCP\"," +
                                       "\"state\":\"DISABLED\",\"secure\":\"YES\"}]}"}
                }
            };
            yield return new object[]
            {
                new LbmonitorAddRequestConfiguration(new LbmonitorAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbmonitorAddTcpRequestData("testMonitor1"),
                        new LbmonitorAddTcpRequestData("testMonitor2")
                        {
                            Secure = "YES",
                            State = "DISABLED"
                        },
                        new LbmonitorAddTcpEcvRequestData("testMonitor3")
                        {
                            Send = "testString"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbmonitor\":[{\"monitorname\":\"testMonitor1\",\"type\":\"TCP\"}," +
                                       "{\"monitorname\":\"testMonitor2\",\"type\":\"TCP\"," +
                                       "\"state\":\"DISABLED\",\"secure\":\"YES\"}," +
                                       "{\"monitorname\":\"testMonitor3\",\"type\":\"TCP-ECV\"," +
                                       "\"send\":\"testString\"}" +
                                       "]}"}
                }
            };
            yield return new object[]
            {
                new LbmonitorAddRequestConfiguration(new LbmonitorAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbmonitorAddTcpRequestData("testMonitor1"),
                        new LbmonitorAddTcpRequestData("testMonitor2")
                        {
                            Secure = "YES",
                            State = "DISABLED"
                        },
                        new LbmonitorAddHttpEcvRequestData("testMonitor3")
                        {
                            Send = "testString", CustomHeaders = "HeaderTest"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbmonitor\":[{\"monitorname\":\"testMonitor1\",\"type\":\"TCP\"}," +
                                       "{\"monitorname\":\"testMonitor2\",\"type\":\"TCP\"," +
                                       "\"state\":\"DISABLED\",\"secure\":\"YES\"}," +
                                       "{\"monitorname\":\"testMonitor3\",\"type\":\"HTTP-ECV\"," +
                                       "\"customheaders\":\"HeaderTest\",\"send\":\"testString\"}" +
                                       "]}"}
                }
            };
            yield return new object[]
            {
                new LbmonitorAddRequestConfiguration(new LbmonitorAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbmonitorAddTcpRequestData("testMonitor1"),
                        new LbmonitorAddTcpRequestData("testMonitor2")
                        {
                            Secure = "YES",
                            State = "DISABLED"
                        },
                        new LbmonitorAddHttpInlineRequestData("testMonitor3")
                        {
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbmonitor\":[{\"monitorname\":\"testMonitor1\",\"type\":\"TCP\"}," +
                                       "{\"monitorname\":\"testMonitor2\",\"type\":\"TCP\"," +
                                       "\"state\":\"DISABLED\",\"secure\":\"YES\"}," +
                                       "{\"monitorname\":\"testMonitor3\",\"type\":\"HTTP-INLINE\"}" +
                                       "]}"}
                }
            };           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}