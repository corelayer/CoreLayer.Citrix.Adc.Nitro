using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelBindingCsPolicyAddRequestConfigurationValidationTestData))]
        public void CsPolicyLabelBindingCsPolicyAddRequestConfigurationValidationTest(
            CsPolicyLabelBindingCsPolicyAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsPolicyLabelBindingCsPolicyAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelBindingCsPolicyAddRequestConfiguration(new CsPolicyLabelBindingCsPolicyAddRequestDataRoot(new CsPolicyLabelBindingCsPolicyAddRequestData())), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel_cspolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel_cspolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"cspolicylabel_cspolicy_binding\":[{}]}"}
                }
            }; 
            yield return new object[]
            {
                new CsPolicyLabelBindingCsPolicyAddRequestConfiguration(new CsPolicyLabelBindingCsPolicyAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsPolicyLabelBindingCsPolicyAddRequestData(),
                        new CsPolicyLabelBindingCsPolicyAddRequestData()
                        {
                            LabelName = "test"
                        },
                        new CsPolicyLabelBindingCsPolicyAddRequestData()
                        {
                            PolicyName = "test"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel_cspolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel_cspolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"cspolicylabel_cspolicy_binding\":[{}," +
                                       "{\"labelname\":\"test\"}," +
                                       "{\"policyname\":\"test\"}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}