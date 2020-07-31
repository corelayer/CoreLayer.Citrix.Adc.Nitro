using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.RNat6
{
    public class RNat6StatsTest
    {
        [Theory]
        [ClassData(typeof(RNat6StatsValidationTestData))]
        public void RNat6StatsValidationTest(RNat6Stats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(RNat6Stats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class RNat6StatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RNat6Stats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new RNat6Stats()
                {
                    RNat6CurrentSessions = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"rnat6cursessions\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new RNat6Stats()
                {
                    RNat6CurrentSessions = "Test",
                    RNat6ReceiveBytesRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"rnat6cursessions\":\"Test\",\"rnat6rxbytesrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}