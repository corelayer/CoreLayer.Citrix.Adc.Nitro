using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.LocationFile
{
    public class LocationFileConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFileConfigurationValidationTestData))]
        public void LocationFileConfigurationValidationTest(LocationFileConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(LocationFileConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class LocationFileConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFileConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new LocationFileConfiguration()
                {
                    LocationFile = "file",
                    Format = "100",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"locationfile\":\"file\",\"format\":\"100\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}