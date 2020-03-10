using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server.ServerAddRequestDatas;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Server
{
    public class ServerAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerAddRequestConfigurationValidationTestData))]
        public void ServerAddRequestConfigurationValidationTest(ServerAddRequestConfiguration configuration,
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
    public class ServerAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[]
            {
                new ServerAddRequestConfiguration(new ServerAddRequestDataRoot(new ServerAddByDomainRequestData("test", "testDomain"))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server"},
                    {"RequestContent", "{\"server\":[{\"name\":\"test\",\"domain\":\"testDomain\",\"domainresolveretry\":5,\"td\":0,\"querytype\":\"A\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServerAddRequestConfiguration(new ServerAddRequestDataRoot(new ServerAddByIpRequestData("test", "testIp"))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server"},
                    {"RequestContent", "{\"server\":[{\"name\":\"test\",\"ipaddress\":\"testIp\",\"td\":0}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServerAddRequestConfiguration(
                    new ServerAddRequestDataRoot(new dynamic[]
                    {
                        new ServerAddByIpRequestData("test", "testIp")
                        {
                            Comment = "testComment",
                            State = "Enabled"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server"},
                    {"RequestContent", "{\"server\":[{\"name\":\"test\",\"ipaddress\":\"testIp\",\"state\":\"Enabled\",\"comment\":\"testComment\",\"td\":0}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServerAddRequestConfiguration(
                    new ServerAddRequestDataRoot(
                        new dynamic[]
                        {
                            new ServerAddByIpRequestData("test", "testIp")
                            {
                                Comment = "testComment",
                                State = "Enabled"
                            }, 
                            new ServerAddByDomainRequestData("testByDom", "testDom")
                            {
                                Comment = "domTestComment"
                            } 
                        })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server"},
                    {"RequestContent", "{\"server\":" +
                                       "[{\"name\":\"test\",\"ipaddress\":\"testIp\",\"state\":\"Enabled\",\"comment\":\"testComment\",\"td\":0}," +
                                       "{\"name\":\"testByDom\",\"domain\":\"testDom\",\"domainresolveretry\":5,\"comment\":\"domTestComment\",\"td\":0,\"querytype\":\"A\"}]}"},
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