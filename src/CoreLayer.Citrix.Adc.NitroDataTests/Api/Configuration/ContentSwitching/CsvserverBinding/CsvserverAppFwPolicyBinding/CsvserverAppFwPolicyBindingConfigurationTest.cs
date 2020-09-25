using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;
using Xunit;
using CoreLayer.Citrix.Adc.NitroClient;
using System.Text.Json;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFwPolicyBinding
{
    public class CsvserverAppFwPolicyBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAppFwPolicyBindingConfigurationValidationTestData))]
        public void CsvserverAppFwPolicyBindingConfigurationValidationTest(
            CsvserverAppFwPolicyBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsvserverAppFwPolicyBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsvserverAppFwPolicyBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAppFwPolicyBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsvserverAppFwPolicyBindingConfiguration()
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