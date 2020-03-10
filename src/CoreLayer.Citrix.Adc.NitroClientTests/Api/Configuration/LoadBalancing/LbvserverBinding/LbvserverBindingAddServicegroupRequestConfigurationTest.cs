using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServicegroupRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverBindingAddServicegroupRequestConfigurationValidationTestData))]
        public void LbvserverBindingAddServicegroupRequestConfigurationValidationTest(
            LbvserverBindingAddServicegroupRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class LbvserverBindingAddServicegroupRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverBindingAddServicegroupRequestConfiguration(new LbvserverBindingAddServicegroupRequestDataRoot(
                    new dynamic[]
                    {
                        new LbvserverBindingAddServicegroupRequestData("testName"),
                        new LbvserverBindingAddServicegroupRequestData("testName2")
                        {
                            ServicegroupName = "testSG"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_servicegroup_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbvserver_servicegroup_binding\":[{\"name\":\"testName\"}," +
                                       "{\"name\":\"testName2\",\"servicegroupname\":\"testSG\"}]}"}   
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}