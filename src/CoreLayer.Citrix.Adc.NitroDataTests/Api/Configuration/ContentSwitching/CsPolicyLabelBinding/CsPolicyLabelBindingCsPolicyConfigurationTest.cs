using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelBindingCsPolicyConfigurationValidationTestData))]
        public void CsPolicyLabelBindingCsPolicyConfigurationValidationTest(
            CsPolicyLabelBindingCsPolicyConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsPolicyLabelBindingCsPolicyConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsPolicyLabelBindingCsPolicyConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelBindingCsPolicyConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyLabelBindingCsPolicyConfiguration()
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
                new CsPolicyLabelBindingCsPolicyConfiguration()
                {
                    PolicyName = "Test",
                    GoToPriorityExpression = "test"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"policyname\":\"Test\",\"gotopriorityexpression\":\"test\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}