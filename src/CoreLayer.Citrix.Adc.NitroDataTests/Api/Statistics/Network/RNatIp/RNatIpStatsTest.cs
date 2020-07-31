using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.RNatIp
{
    public class RNatIpStatsTest 
    {
        [Theory]
        [ClassData(typeof(RNatIpStatsValidationTestData))]
        public void RNatIpStatsValidationTest(RNatIpStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(RNatIpStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class RNatIpStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RNatIpStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new RNatIpStats()
                {
                    IpRNatCurrentSessions = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"iprnatcursessions\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new RNatIpStats()
                {
                    IpRNatCurrentSessions = "Test",
                    IpRNatReceiveBytesRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"iprnatcursessions\":\"Test\",\"iprnatrxbytesrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}