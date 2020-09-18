using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingRemoveDosPolicyRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingRemoveDosPolicyRequestConfigurationValidationTestData))]
        public void ServiceBindingRemoveDosPolicyRequestConfigurationValidationTest(
            ServiceBindingRemoveDosPolicyRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServiceBindingRemoveDosPolicyRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingRemoveDosPolicyRequestConfiguration()
                {
                    Options =new ServiceBindingRemoveDosPolicyRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testS"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/service_dospolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/service_dospolicy_binding?args=name:testS"},
                    {"Options", "?args=name:testS"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}