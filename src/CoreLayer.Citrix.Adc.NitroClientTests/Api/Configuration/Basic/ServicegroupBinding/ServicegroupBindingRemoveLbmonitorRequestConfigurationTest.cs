using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveLbmonitorRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupBindingRemoveLbmonitorRequestConfigurationValidationTestData))]
        public void ServicegroupBindingRemoveLbmonitorRequestConfigurationValidationTest(
                ServicegroupBindingRemoveLbmonitorRequestConfiguration configuration,
                Dictionary<string, string> expected)
            {
                Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
                Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
                Assert.Equal(expected["Method"], configuration.Method.ToString());
                Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
                Assert.Equal(expected["Options"], configuration.Options.ToString());
            }
    }
    public class ServicegroupBindingRemoveLbmonitorRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupBindingRemoveLbmonitorRequestConfiguration()
                {
                    Options =new ServicegroupBindingRemoveLbmonitorRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"servicegroupname", "testSG"},{"monitor_name","testMon"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_lbmonitor_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_lbmonitor_binding?args=servicegroupname:testSG,monitor_name:testMon"},
                    {"Options", "?args=servicegroupname:testSG,monitor_name:testMon"},
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}