using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding
{
    public class CsvserverBotPolicyBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverBotPolicyBindingConfigurationValidationTestData))]
        public void CsvserverBotPolicyBindingConfigurationValidationTest(
            CsvserverBotPolicyBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsvserverBotPolicyBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsvserverBotPolicyBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverBotPolicyBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsvserverBotPolicyBindingConfiguration()
                {
                    Name = "test",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"test\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}