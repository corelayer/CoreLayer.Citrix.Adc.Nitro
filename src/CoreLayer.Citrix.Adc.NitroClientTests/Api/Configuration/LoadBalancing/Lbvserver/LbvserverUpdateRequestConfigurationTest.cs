using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverUpdateRequestDatas;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverUpdateRequestConfigurationValidationTestData))]
        public void LbvserverUpdateRequestConfigurationValidationTest(LbvserverUpdateRequestConfiguration configuration,
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

    public class LbvserverUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverUpdateRequestConfiguration(new LbvserverUpdateRequestDataRoot(new LbvserverUpdateHttpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"RequestContent", "{\"lbvserver\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LbvserverUpdateRequestConfiguration(
                    new LbvserverUpdateRequestDataRoot(new dynamic[]
                    {
                        new LbvserverUpdateTcpRequestData("test")
                        {
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"RequestContent", "{\"lbvserver\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LbvserverUpdateRequestConfiguration(new LbvserverUpdateRequestDataRoot(new LbvserverUpdateSyslogUdpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"RequestContent", "{\"lbvserver\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LbvserverUpdateRequestConfiguration(new LbvserverUpdateRequestDataRoot(new LbvserverUpdateSyslogTcpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"RequestContent", "{\"lbvserver\":[{\"name\":\"test\"}]}"},
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