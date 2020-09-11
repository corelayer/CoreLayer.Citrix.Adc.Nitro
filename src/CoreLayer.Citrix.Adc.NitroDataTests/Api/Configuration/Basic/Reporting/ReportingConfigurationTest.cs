using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.Reporting
{
    public class ReportingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ReportingConfigurationValidationTestData))]
        public void ReportingConfigurationValidationTest(ReportingConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ReportingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ReportingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ReportingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ReportingConfiguration()
                {
                    State = "state",
                    
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"state\":\"state\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}