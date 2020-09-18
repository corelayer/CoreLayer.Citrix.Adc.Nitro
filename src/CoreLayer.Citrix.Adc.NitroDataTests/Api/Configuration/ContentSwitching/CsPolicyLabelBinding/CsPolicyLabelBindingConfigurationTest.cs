using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelBindingConfigurationValidationTestData))]
        public void CsPolicyLabelBindingConfigurationValidationTest(CsPolicyLabelBindingConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsPolicyLabelBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsPolicyLabelBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyLabelBindingConfiguration()
                {
                    LabelName = "test",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"labelname\":\"test\"}"}
                }
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}