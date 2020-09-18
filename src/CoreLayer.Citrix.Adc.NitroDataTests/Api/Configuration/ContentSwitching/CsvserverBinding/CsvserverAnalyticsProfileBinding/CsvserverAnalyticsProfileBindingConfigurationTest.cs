using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;
using CoreLayer.Citrix.Adc.NitroClient;
using System.Text.Json;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAnalyticsProfileBindingConfigurationValidationTestData))]
        public void CsvserverAnalyticsProfileBindingConfigurationValidationTestData(
            CsvserverAnalyticsProfileBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsvserverAnalyticsProfileBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsvserverAnalyticsProfileBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAnalyticsProfileBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsvserverAnalyticsProfileBindingConfiguration()
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