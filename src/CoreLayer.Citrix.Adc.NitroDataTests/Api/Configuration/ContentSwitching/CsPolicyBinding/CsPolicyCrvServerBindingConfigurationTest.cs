using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCrvServerBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyCrvServerBindingConfigurationValidationTestData))]
        public void CsPolicyCrvServerBindingConfigurationValidationTest(
            CsPolicyCrvServerBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsPolicyCrvServerBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsPolicyCrvServerBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyCrvServerBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsPolicyCrvServerBindingConfiguration()
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
                new CsPolicyCrvServerBindingConfiguration()
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