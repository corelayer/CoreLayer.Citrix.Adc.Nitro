using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelRenameRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelRenameRequestConfigurationValidationTestData))]
        public void CsPolicyLabelRenameRequesyConfigurationValidationTest(
            CsPolicyLabelRenameRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsPolicyLabelRenameRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelRenameRequestConfiguration(new CsPolicyLabelRenameRequestDataRoot(new CsPolicyLabelRenameRequestData()
                {
                    LabelName = "test"
                })), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel?action=rename"},
                    {"RequestContent", "{\"cspolicylabel\":{\"labelname\":\"test\"}}"},
                    {"Options", "?action=rename"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}