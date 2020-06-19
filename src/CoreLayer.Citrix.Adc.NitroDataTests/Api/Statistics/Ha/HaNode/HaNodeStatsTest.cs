using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ha;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ha.HaNode
{
    public class HaNodeStatsTest
    {
        [Theory]
        [ClassData(typeof(HaNodeTestData))]
        public void HaNodeTest(HaNodeStats haNodeStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(haNodeStats, typeof(HaNodeStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class HaNodeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new HaNodeStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new HaNodeStats()
                {
                    HighAvailabilityCurrentState = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"hacurstate\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new HaNodeStats()
                {
                    HighAvailabilityCurrentState = "Test",
                    HighAvailabilityPacketReceiveRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"hacurstate\":\"Test\",\"hapktrxrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}