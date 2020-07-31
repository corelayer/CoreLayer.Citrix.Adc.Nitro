using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Gslb.GslbVserver
{
    public class GslbVserverStatsTest
    {
        [Theory]
        [ClassData(typeof(GslbVserverStatsValidationTestData))]
        public void GslbVserverStatsValidationTest(GslbVserverStats stats, Dictionary<string, string> expected)
        {
             Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(GslbVserverStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GslbVserverStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GslbVserverStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new GslbVserverStats()
                {
                    Name = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new GslbVserverStats()
                {
                    Name = "Test",
                    RequestsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"requestsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}