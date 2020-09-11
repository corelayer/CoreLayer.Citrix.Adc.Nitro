using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6ConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFile6ConfigurationValidationTestData))]
        public void LocationFile6ConfigurationValidationTest(LocationFile6Configuration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(LocationFile6Configuration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class LocationFile6ConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFile6Configuration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new LocationFile6Configuration()
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