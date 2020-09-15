using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingRemoveScPolicyRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingRemoveScPolicyRequestConfigurationValidationTestData))]
        public void ServiceBindingRemoveScPolicyRequestConfigurationValidationTest(
            ServiceBindingRemoveScPolicyRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServiceBindingRemoveScPolicyRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingRemoveScPolicyRequestConfiguration()
                {
                    Options =new ServiceBindingRemoveScPolicyRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testS"},{"monitor_name","testMon"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/service_scpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/service_scpolicy_binding?args=name:testS,monitor_name:testMon"},
                    {"Options", "?args=name:testS,monitor_name:testMon"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}