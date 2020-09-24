using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAPBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAPBindingGetRequestConfigurationValidationTestData))]
        public void CsvserverAPBindingGetRequestConfigurationValidationTest(
            CsvserverAuthorizationPolicyBindingGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverAPBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuthorizationPolicyBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_authorizationpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_authorizationpolicy_binding?bulkbindings=yes"},
                    {"Method", "GET"},
                    {"Options", "?bulkbindings=yes"}
                }
            };
            
            yield return new object[]
            {
                new CsvserverAuthorizationPolicyBindingGetRequestConfiguration
                {
                    Options = new CsvserverAuthorizationPolicyBindingGetRequestOptions()
                    {
                        ResourceFilter = new Dictionary<string, string>(),
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        },
                        ResourceName = "instance1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_authorizationpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_authorizationpolicy_binding/instance1?attrs=Filter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=Filter"},
                }
            };
            yield return new object[]
            {
                new CsvserverAuthorizationPolicyBindingGetRequestConfiguration
                {
                    Options = new CsvserverAuthorizationPolicyBindingGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        },
                        ResourceName = "instance1",
                        Action = "testAction"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_authorizationpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_authorizationpolicy_binding/instance1?action=testAction"},
                    {"Method", "GET"},
                    {"Options", "/instance1?action=testAction"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}