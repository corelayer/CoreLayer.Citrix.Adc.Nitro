using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver.CsvserverAddRequestDatas;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAddRequestConfigurationValidationTestData))]
        public void CsvserverAddRequestConfigurationValidationTest(CsvserverAddRequestConfiguration configuration,
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
    public class CsvserverAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAddRequestConfiguration(new CsvserverAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAddTcpRequestData("test1"),
                        new CsvserverAddDnsRequestData("test2")
                        {
                            DisablePrimaryOnDown = "YES"
                        },
                        new CsvserverAddDnsTcpRequestData("test3")
                        {
                            Comment = "testComment"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver\":[{\"servicetype\":\"TCP\",\"name\":\"test1\"}," +
                                       "{\"servicetype\":\"DNS\",\"name\":\"test2\",\"disableprimaryondown\":\"YES\"}," +
                                       "{\"servicetype\":\"DNS_TCP\",\"name\":\"test3\",\"comment\":\"testComment\"}]}"}
                }
            }; 
            yield return new object[]
            {
                new CsvserverAddRequestConfiguration(new CsvserverAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAddHttpRequestData("test1"),
                        new CsvserverAddSslRequestData("test2")
                        {
                            DisablePrimaryOnDown = "YES"
                        },
                        new CsvserverAddSslTcpRequestData("test3")
                        {
                            Comment = "testComment"
                        },
                        new CsvserverAddUdpRequestData("test4", "1.1.1.1", 40)
                        {
                            AppFlowLog = "ENABLED"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver\":[{\"servicetype\":\"HTTP\",\"name\":\"test1\"}," +
                                       "{\"servicetype\":\"SSL\",\"name\":\"test2\",\"disableprimaryondown\":\"YES\"}," +
                                       "{\"servicetype\":\"SSL_TCP\",\"name\":\"test3\",\"comment\":\"testComment\"}," +
                                       "{\"servicetype\":\"UDP\",\"name\":\"test4\",\"ipv46\":\"1.1.1.1\",\"port\":40,\"appflowlog\":\"ENABLED\"}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}