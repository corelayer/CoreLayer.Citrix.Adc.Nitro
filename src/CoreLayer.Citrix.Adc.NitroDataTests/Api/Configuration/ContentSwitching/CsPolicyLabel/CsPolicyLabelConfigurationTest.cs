using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelConfigurationValidationTestData))]
        public void CsPolicyLabelConfigurationValidationTest(CsPolicyLabelConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsPolicyLabelConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsPolicyLabelConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyLabelConfiguration()
                {
                    PolicyName = "test",
                    Hits = "0"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"hits\":\"0\",\"policyname\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyLabelConfiguration()
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