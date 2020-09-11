using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationParameterConfigurationValidationTestData))]
        public void LocationParameterConfigurationValidationTest(LocationParameterConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(LocationParameterConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class LocationParameterConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationParameterConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new LocationParameterConfiguration()
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