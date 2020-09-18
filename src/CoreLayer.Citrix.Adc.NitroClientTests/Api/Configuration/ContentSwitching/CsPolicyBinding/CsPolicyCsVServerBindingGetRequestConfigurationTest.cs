using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsVServerBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyCsVServerBindingGetRequestConfigurationValidationTestData))]
        public void CsPolicyCsVServerBindingGetRequestConfigurationValidationTest(
            CsPolicyCsVServerBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsPolicyCsVServerBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyCsVServerBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/cspolicy_csvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicy_csvserver_binding"},
                    {"Method", "GET"},
                    {"Options", ""}
                }
            };
            
            yield return new object[]
            {
                new CsPolicyCsVServerBindingGetRequestConfiguration
                {
                    Options = new CsPolicyCsVServerBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/cspolicy_csvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicy_csvserver_binding/instance1?attrs=Filter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=Filter"},
                }
            };
            yield return new object[]
            {
                new CsPolicyCsVServerBindingGetRequestConfiguration
                {
                    Options = new CsPolicyCsVServerBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/cspolicy_csvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicy_csvserver_binding/instance1?action=testAction"},
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