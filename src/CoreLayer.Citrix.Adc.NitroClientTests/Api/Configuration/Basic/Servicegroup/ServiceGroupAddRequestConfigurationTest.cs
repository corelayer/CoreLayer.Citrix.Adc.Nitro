using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Servicegroup
{
    public class ServiceGroupAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceGroupAddRequestConfigurationValidationTestData))]
        public void ServiceGroupAddRequestConfigurationValidationTest(
            ServicegroupAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServiceGroupAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupAddRequestConfiguration(new ServicegroupAddRequestDataRoot(
                    new dynamic[]
                    {
                        new ServicegroupAddDnsRequestData("test1"), 
                        new ServicegroupAddHttpRequestData("test2")
                        {
                            State = "DISABLED"
                        },
                        new ServicegroupAddSslRequestData("test3")
                        {
                            MaxBandwidth = 20,
                            AppFlowLog = "YES"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"Options", ""},
                    {"RequestContent", "{\"servicegroup\":[{\"servicetype\":\"DNS\",\"servicegroupname\":\"test1\"}," +
                                       "{\"servicetype\":\"HTTP\",\"state\":\"DISABLED\",\"servicegroupname\":\"test2\"}," +
                                       "{\"servicetype\":\"SSL\",\"maxbandwidth\":20,\"appflowlog\":\"YES\",\"servicegroupname\":\"test3\"}" +
                                       "]}"}
                }
            };  
            yield return new object[]
            {
                new ServicegroupAddRequestConfiguration(new ServicegroupAddRequestDataRoot(
                    new dynamic[]
                    {
                        new ServicegroupAddSslBridgeRequestData("test1"), 
                        new ServicegroupAddSslTcpRequestData("test2")
                        {
                            State = "DISABLED"
                        },
                        new ServicegroupAddSyslogTcpRequestData("test3")
                        {
                            MaxBandwidth = 20,
                            AppFlowLog = "YES"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"Options", ""},
                    {"RequestContent", "{\"servicegroup\":[{\"servicetype\":\"SSL_BRIDGE\",\"servicegroupname\":\"test1\"}," +
                                       "{\"servicetype\":\"SSL_TCP\",\"state\":\"DISABLED\",\"servicegroupname\":\"test2\"}," +
                                       "{\"servicetype\":\"SYSLOGTCP\",\"maxbandwidth\":20,\"appflowlog\":\"YES\",\"servicegroupname\":\"test3\"}" +
                                       "]}"}
                }
            };    
            yield return new object[]
            {
                new ServicegroupAddRequestConfiguration(new ServicegroupAddRequestDataRoot(
                    new dynamic[]
                    {
                        new ServicegroupAddSyslogUdpRequestData("test1"), 
                        new ServicegroupAddUdpRequestData("test2")
                        {
                            State = "DISABLED"
                        },
                        new ServicegroupAddTcpRequestData("test3")
                        {
                            MaxBandwidth = 20,
                            AppFlowLog = "YES"
                        },
                        new ServicegroupAddDnsTcpRequestData("test4")
                        {
                            SvrTimeout = 2,
                            Comment = "testComment"
                        }, 
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"Options", ""},
                    {"RequestContent", "{\"servicegroup\":[{\"servicetype\":\"SYSLOGUDP\",\"servicegroupname\":\"test1\"}," +
                                       "{\"servicetype\":\"UDP\",\"state\":\"DISABLED\",\"servicegroupname\":\"test2\"}," +
                                       "{\"servicetype\":\"TCP\",\"maxbandwidth\":20,\"appflowlog\":\"YES\",\"servicegroupname\":\"test3\"}," +
                                       "{\"servicetype\":\"DNS_TCP\",\"svrtimeout\":2,\"comment\":\"testComment\",\"servicegroupname\":\"test4\"}" +
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