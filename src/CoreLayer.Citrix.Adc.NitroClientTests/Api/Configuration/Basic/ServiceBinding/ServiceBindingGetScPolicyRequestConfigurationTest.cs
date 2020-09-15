using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingGetScPolicyRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingGetScPolicyRequestConfigurationValidationTestData))]
        public void ServiceBindingGetScPolicyRequestConfigurationValidationTest(
            ServiceBindingGetScPolicyRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServiceBindingGetScPolicyRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingGetScPolicyRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/service_scpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/service_scpolicy_binding?bulkbindings=yes"},
                    {"Options", "?bulkbindings=yes"},
                }, 
            };
            yield return new object[]
            {
                new ServiceBindingGetScPolicyRequestConfiguration
                {
                    Options = new ServiceBindingGetScPolicyRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }, Count = true
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/service_scpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/service_scpolicy_binding?bulkbindings=yes&count=yes&attrs=Filter"},
                    {"Options", "?bulkbindings=yes&count=yes&attrs=Filter"}
                    
                }
            };
            yield return new object[]
            {
                new ServiceBindingGetScPolicyRequestConfiguration
                {
                    Options = new ServiceBindingGetScPolicyRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "ServiceGroupName"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/service_scpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/service_scpolicy_binding?bulkbindings=yes&attrs=ServiceGroupName"},
                    {"Options", "?bulkbindings=yes&attrs=ServiceGroupName"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}