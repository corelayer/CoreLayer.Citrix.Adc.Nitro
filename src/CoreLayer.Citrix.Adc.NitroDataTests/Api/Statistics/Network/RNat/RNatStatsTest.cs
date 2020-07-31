using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.RNat
{
    public class RNatStatsTest
    {
        [Theory]
        [ClassData(typeof(RNatStatsValidationTestData))]
        public void RNatStatsValidationTest(RNatStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(RNatStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class RNatStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RNatStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new RNatStats()
                {
                    RNatCurrentSessions = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"rnatcursessions\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new RNatStats()
                {
                    RNatCurrentSessions = "Test",
                    RNatReceiveBytesRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"rnatcursessions\":\"Test\",\"rnatrxbytesrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}