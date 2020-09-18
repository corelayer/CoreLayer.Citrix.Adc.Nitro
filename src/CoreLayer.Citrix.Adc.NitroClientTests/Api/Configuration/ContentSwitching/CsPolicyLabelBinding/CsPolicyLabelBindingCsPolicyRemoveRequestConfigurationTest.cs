using System.Collections;
using System.Collections.Generic;
using System.Security;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelBindingCsPolicyRemoveRequestConfigurationValidationTestData))]
        public void CsPolicyLabelBindingCsPolicyRemoveRequestConfigurationValidationTest(
            CsPolicyLabelBindingCsPolicyRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsPolicyLabelBindingCsPolicyRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelBindingCsPolicyRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel_cspolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel_cspolicy_binding"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new CsPolicyLabelBindingCsPolicyRemoveRequestConfiguration()
                {
                    Options = new CsPolicyLabelBindingCsPolicyRemoveRequestOptions()
                    {
                        ResourceName = "resource"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel_cspolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel_cspolicy_binding/resource"},
                    {"Options", "/resource"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}