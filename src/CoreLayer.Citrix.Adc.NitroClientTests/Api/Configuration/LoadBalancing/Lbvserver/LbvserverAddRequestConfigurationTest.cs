using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverAddRequestConfigurationValidationTestData))]
        public void LbvserverAddRequestConfigurationValidationTest(LbvserverAddRequestConfiguration configuration,
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
    public class LbvserverAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverAddRequestConfiguration(new LbvserverAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbvserverAddDnsRequestData("test1"),
                        new LbvserverAddDnsTcpRequestData("test2")
                        {
                            State = "DISABLED"
                        },
                        new LbvserverAddHttpRequestData("test3")
                        {
                            AppFlowLogging = "ENABLED"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbvserver\":[{\"servicetype\":\"DNS\",\"name\":\"test1\"}," +
                                       "{\"servicetype\":\"DNS_TCP\",\"name\":\"test2\",\"state\":\"DISABLED\"}," +
                                       "{\"servicetype\":\"HTTP\",\"name\":\"test3\",\"appflowlog\":\"ENABLED\"}]}"}
                }
            };
            yield return new object[]
            {
                new LbvserverAddRequestConfiguration(new LbvserverAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbvserverAddSslBridgeRequestData("test1"),
                        new LbvserverAddSslRequestData("test2")
                        {
                            Rule = "testRule"
                        },
                        new LbvserverAddSslTcpRequestData("test3")
                        {
                            Comment = "testComment"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbvserver\":[{\"servicetype\":\"SSL_BRIDGE\",\"name\":\"test1\"}," +
                                       "{\"servicetype\":\"SSL\",\"name\":\"test2\",\"rule\":\"testRule\"}," +
                                       "{\"servicetype\":\"SSL_TCP\",\"name\":\"test3\",\"comment\":\"testComment\"}]}"}
                }
            };
            yield return new object[]
            {
                new LbvserverAddRequestConfiguration(new LbvserverAddRequestDataRoot(
                    new dynamic[]
                    {
                        new LbvserverAddSyslogTcpRequestData("test1"),
                        new LbvserverAddSyslogUdpRequestData("test2")
                        {
                            DisablePrimaryOnDown = "YES"
                        },
                        new LbvserverAddTcpRequestData("test3")
                        {
                            CookieName = "testCookie"
                        },
                        new LbvserverAddUdpRequestData("test4")
                        {
                            LoadBalancingMethod = "testMethod"
                        }, 
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbvserver\":[{\"servicetype\":\"SYSLOGTCP\",\"name\":\"test1\"}," +
                                       "{\"servicetype\":\"SYSLOGUDP\",\"name\":\"test2\",\"disableprimaryondown\":\"YES\"}," +
                                       "{\"servicetype\":\"TCP\",\"name\":\"test3\",\"cookiename\":\"testCookie\"}," +
                                       "{\"servicetype\":\"UDP\",\"name\":\"test4\",\"lbmethod\":\"testMethod\"}" +
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