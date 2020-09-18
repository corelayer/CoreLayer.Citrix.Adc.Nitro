using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsPolicyLabelBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyCsPolicyLabelBindingGetRequestConfigurationValidationTestData))]
        public void CsPolicyCsPolicyLabelBindingGetRequestConfigurationValidationTest(
            CsPolicyCsPolicyLabelBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsPolicyCsPolicyLabelBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyCsPolicyLabelBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/cspolicy_cspolicylabel_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicy_cspolicylabel_binding?bulkbindings=yes"},
                    {"Method", "GET"},
                    {"Options", "?bulkbindings=yes"}
                }
            };
            
            yield return new object[]
            {
                new CsPolicyCsPolicyLabelBindingGetRequestConfiguration
                {
                    Options = new CsPolicyCsPolicyLabelBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/cspolicy_cspolicylabel_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicy_cspolicylabel_binding/instance1?attrs=Filter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=Filter"},
                }
            };
            yield return new object[]
            {
                new CsPolicyCsPolicyLabelBindingGetRequestConfiguration
                {
                    Options = new CsPolicyCsPolicyLabelBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/cspolicy_cspolicylabel_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicy_cspolicylabel_binding/instance1?action=testAction"},
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