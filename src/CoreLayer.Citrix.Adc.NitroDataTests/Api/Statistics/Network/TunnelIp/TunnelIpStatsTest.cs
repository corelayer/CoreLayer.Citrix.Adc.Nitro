using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.TunnelIp
{
    public class TunnelIpStatsTest
    {
        [Theory]
        [ClassData(typeof(TunnelIpStatsValidationTestData))]
        public void TunnelIpStatsValidationTest(TunnelIpStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(TunnelIpStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class TunnelIpStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TunnelIpStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new TunnelIpStats()
                {
                    TunnelIp = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"tunnelip\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new TunnelIpStats()
                {
                    TunnelIp = "Test",
                    TunnelReceiveBytesRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"tunnelip\":\"Test\",\"tnlrxbytesrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}