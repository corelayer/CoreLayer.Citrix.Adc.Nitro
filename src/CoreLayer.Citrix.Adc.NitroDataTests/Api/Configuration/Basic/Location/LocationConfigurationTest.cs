using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.Location
{
    public class LocationConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationConfigurationValidationTestData))]
        public void LocationConfigurationValidationTest(LocationConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(LocationConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class LocationConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new LocationConfiguration()
                {
                     Longitude = 10,
                     IpFrom = "100",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"ipfrom\":\"100\",\"longitude\":10}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}