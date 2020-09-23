using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;
using Xunit;
using CoreLayer.Citrix.Adc.NitroClient;
using System.Text.Json;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAppQoePolicyBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAppQoePolicyBindingConfigurationValidationTestData))]
        public void CsvserverAppQoePolicyBindingConfigurationValidationTest(
            CsvserverAppQoePolicyBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsvserverAppQoePolicyBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsvserverAppQoePolicyBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAppQoePolicyBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsvserverAppQoePolicyBindingConfiguration()
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