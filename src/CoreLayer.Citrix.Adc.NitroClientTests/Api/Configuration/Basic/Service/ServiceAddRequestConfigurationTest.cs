using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceAddRequestDatas;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Service
{
    public class ServiceAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceAddRequestConfigurationValidationTestData))]
        public void ServiceAddRequestConfigurationValidationTest(
            ServiceAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServiceAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddTcpRequestData("testService", "1.1.1.1", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"TCP\",\"port\":10," +
                                       "\"name\":\"testService\",\"ip\":\"1.1.1.1\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddDnsRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"DNS\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddDnsTcpRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"DNS_TCP\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddHttpRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"HTTP\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddSslBridgeRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"SSL_BRIDGE\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddSslRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"SSL\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddSslTcpRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"SSL_TCP\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddSyslogTcpRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"SYSLOGTCP\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddSyslogUdpRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"SYSLOGUDP\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
            yield return new object[]
            {
                new ServiceAddRequestConfiguration(new ServiceAddRequestDataRoot(new ServiceAddUdpRequestData("testService", "testTargetServer", 10))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                    {"RequestContent", "{\"service\":[{\"servicetype\":\"UDP\",\"port\":10," +
                                       "\"name\":\"testService\",\"servername\":\"testTargetServer\"}]}"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}