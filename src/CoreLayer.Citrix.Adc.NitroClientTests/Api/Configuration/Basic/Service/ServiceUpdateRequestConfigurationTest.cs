using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceUpdateRequestDatas;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Service
{
    public class ServiceUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceUpdateRequestConfigurationValidationTestData))]
        public void ServiceUpdateRequestConfigurationValidationTest(ServiceUpdateRequestConfiguration configuration,
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

    public class ServiceUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceUpdateRequestConfiguration(new ServiceUpdateRequestDataRoot(new ServiceUpdateHttpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"RequestContent", "{\"service\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServiceUpdateRequestConfiguration(
                    new ServiceUpdateRequestDataRoot(new dynamic[]
                    {
                        new ServiceUpdateTcpRequestData("test")
                        {
                            TcpProfileName = "testProf"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"RequestContent", "{\"service\":[{\"tcpprofilename\":\"testProf\",\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServiceUpdateRequestConfiguration(new ServiceUpdateRequestDataRoot(new ServiceUpdateSslRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"RequestContent", "{\"service\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServiceUpdateRequestConfiguration(new ServiceUpdateRequestDataRoot(new ServiceUpdateSslBridgeRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"RequestContent", "{\"service\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServiceUpdateRequestConfiguration(new ServiceUpdateRequestDataRoot(new ServiceUpdateUdpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"RequestContent", "{\"service\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServiceUpdateRequestConfiguration(new ServiceUpdateRequestDataRoot(new ServiceUpdateSyslogTcpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"RequestContent", "{\"service\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServiceUpdateRequestConfiguration(new ServiceUpdateRequestDataRoot(new ServiceUpdateSyslogUdpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"RequestContent", "{\"service\":[{\"name\":\"test\"}]}"},
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