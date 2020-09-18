using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsVServerBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyCsVServerBindingConfigurationValidationTestData))]
        public void CsPolicyCsVServerBindingConfigurationValidationTest(
            CsPolicyCsVServerBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsPolicyCsVServerBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsPolicyCsVServerBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyCsVServerBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyCsVServerBindingConfiguration()
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
                new CsPolicyCsVServerBindingConfiguration()
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