using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingRemoveServiceRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverBindingRemoveServiceRequestConfigurationValidationTestData))]
        public void LbvserverBindingRemoveServiceRequestConfigurationValidationTest(
            LbvserverBindingRemoveServiceRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class LbvserverBindingRemoveServiceRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverBindingRemoveServiceRequestConfiguration()
                {
                    Options =new LbvserverBindingRemoveServiceRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testLB"},{"servicename","testServer"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_service_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_service_binding?args=name:testLB,servicename:testServer"},
                    {"Options", "?args=name:testLB,servicename:testServer"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}