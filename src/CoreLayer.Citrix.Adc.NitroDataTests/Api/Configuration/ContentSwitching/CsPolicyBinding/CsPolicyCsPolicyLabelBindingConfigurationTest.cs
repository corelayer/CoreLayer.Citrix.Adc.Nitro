using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsPolicyLabelBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyCsPolicyLabelBindingConfigurationValidationTestData))]
        public void CsPolicyCsPolicyLabelBindingConfigurationValidationTestData(
            CsPolicyCsPolicyLabelBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsPolicyCsPolicyLabelBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsPolicyCsPolicyLabelBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyCsPolicyLabelBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyCsPolicyLabelBindingConfiguration()
                {
                    PolicyName = "test",
                    LabelType = "0"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"policyname\":\"test\",\"labeltype\":\"0\"}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyCsPolicyLabelBindingConfiguration()
                {
                    PolicyName = "Test",
                    LabelName = "test"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"policyname\":\"Test\",\"labelname\":\"test\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}