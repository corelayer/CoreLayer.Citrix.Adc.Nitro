using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingRemoveServicegroupRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverBindingRemoveServicegroupRequestConfigurationValidationTestData))]
        public void LbvserverBindingRemoveServicegroupRequestConfigurationValidationTest(
            LbvserverBindingRemoveServicegroupRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class LbvserverBindingRemoveServicegroupRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverBindingRemoveServicegroupRequestConfiguration()
                {
                    Options =new LbvserverBindingRemoveServicegroupRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testLB"},{"servicegroupname","testSG"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_servicegroup_binding?args=name:testLB,servicegroupname:testSG"},
                    {"Options", "?args=name:testLB,servicegroupname:testSG"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}