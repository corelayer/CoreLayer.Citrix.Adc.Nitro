using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;
using Xunit;
using CoreLayer.Citrix.Adc.NitroClient;
using System.Text.Json;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAuthorizationPolicyBindingConfigurationValidationTestData))]
        public void CsvserverAuthorizationPolicyBindingConfigurationValidationTest(
            CsvserverAuthorizationPolicyBindingConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsvserverAuthorizationPolicyBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsvserverAuthorizationPolicyBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuthorizationPolicyBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsvserverAuthorizationPolicyBindingConfiguration()
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