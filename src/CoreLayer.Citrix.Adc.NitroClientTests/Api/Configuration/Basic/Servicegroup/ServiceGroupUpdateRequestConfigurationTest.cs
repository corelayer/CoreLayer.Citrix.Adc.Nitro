using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Servicegroup
{
    public class ServiceGroupUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupUpdateRequestConfigurationValidationTestData))]
        public void ServicegroupUpdateRequestConfigurationValidationTest(
            ServicegroupUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServicegroupUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupUpdateRequestConfiguration(new ServicegroupUpdateRequestDataRoot(new ServicegroupUpdateHttpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"RequestContent", "{\"servicegroup\":[{\"servicegroupname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServicegroupUpdateRequestConfiguration(
                    new ServicegroupUpdateRequestDataRoot(new dynamic[]
                    {
                        new ServicegroupUpdateTcpRequestData("test")
                        {
                            TcpProfileName = "testProf"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"RequestContent", "{\"servicegroup\":[{\"tcpprofilename\":\"testProf\",\"servicegroupname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServicegroupUpdateRequestConfiguration(new ServicegroupUpdateRequestDataRoot(new ServicegroupUpdateSslRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"RequestContent", "{\"servicegroup\":[{\"servicegroupname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServicegroupUpdateRequestConfiguration(new ServicegroupUpdateRequestDataRoot(new ServicegroupUpdateSslBridgeRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"RequestContent", "{\"servicegroup\":[{\"servicegroupname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServicegroupUpdateRequestConfiguration(new ServicegroupUpdateRequestDataRoot(new ServicegroupUpdateUdpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"RequestContent", "{\"servicegroup\":[{\"servicegroupname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServicegroupUpdateRequestConfiguration(new ServicegroupUpdateRequestDataRoot(new ServicegroupUpdateSyslogTcpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"RequestContent", "{\"servicegroup\":[{\"servicegroupname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServicegroupUpdateRequestConfiguration(new ServicegroupUpdateRequestDataRoot(new ServicegroupUpdateSyslogUdpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"RequestContent", "{\"servicegroup\":[{\"servicegroupname\":\"test\"}]}"},
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