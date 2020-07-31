using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.Bridge
{
    public class BridgeStatsTest
    {
        [Theory]
        [ClassData(typeof(BridgeStatsValidationTestData))]
        public void BridgeStatsValidationTestData(BridgeStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(BridgeStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class BridgeStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new BridgeStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new BridgeStats()
                {
                    TcpErrorBridgeMuted = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"tcperrbdgmuted\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new BridgeStats()
                {
                    TotalBridgedMbits = "Test",
                    BridgedMbitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"totbdgmbits\":\"Test\",\"bdgmbitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}