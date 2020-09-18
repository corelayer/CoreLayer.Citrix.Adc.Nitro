using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddDosPolicyRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingAddDosPolicyRequestConfigurationValidationTestData))]
        public void ServiceBindingAddDosPolicyRequestConfigurationValidationTest(
            ServiceBindingAddDosPolicyRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServiceBindingAddDosPolicyRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingAddDosPolicyRequestConfiguration(new ServiceBindingAddDosPolicyRequestDataRoot(
                    new dynamic[]
                    {
                        new ServiceBindingAddDosPolicyRequestData()
                        {
                            Name = "test"
                        }, 
                        new ServiceBindingAddDosPolicyRequestData()
                        {
                            PolicyName = "testPol"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service_dospolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/service_dospolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"service_dospolicy_binding\":[{\"name\":\"test\"}," +
                                       "{\"policyname\":\"testPol\"}" +
                                       "]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}