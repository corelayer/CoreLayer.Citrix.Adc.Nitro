using System.Collections;
using System.Collections.Generic;
using System.Security;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelAddRequestConfigurationValidationTestData))]
        public void CsPolicyLabelAddRequestConfigurationValidationTest(
            CsPolicyLabelAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsPolicyLabelAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelAddRequestConfiguration(new CsPolicyLabelAddRequestDataRoot(new CsPolicyLabelAddRequestData())), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel"},
                    {"Options", ""},
                    {"RequestContent", "{\"cspolicylabel\":[{}]}"}
                }
            }; 
            yield return new object[]
            {
                new CsPolicyLabelAddRequestConfiguration(new CsPolicyLabelAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsPolicyLabelAddRequestData(),
                        new CsPolicyLabelAddRequestData()
                        {
                            LabelName = "test"
                        },
                        new CsPolicyLabelAddRequestData()
                        {
                            CsPolicyLabelType = "test"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel"},
                    {"Options", ""},
                    {"RequestContent", "{\"cspolicylabel\":[{}," +
                                       "{\"labelname\":\"test\"}," +
                                       "{\"cspolicylabeltype\":\"test\"}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}