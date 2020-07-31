using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.TunnelIp6
{
    public class TunnelIp6StatsTest
    {
        [Theory]
        [ClassData(typeof(TunnelIp6StatsValidationTestData))]
        public void TunnelIp6StatsValidationTest(TunnelIp6Stats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(TunnelIp6Stats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class TunnelIp6StatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new TunnelIp6Stats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new TunnelIp6Stats()
                {
                    TunnelIp6 = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"tunnelip6\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new TunnelIp6Stats()
                {
                    TunnelIp6 = "Test",
                    TunnelReceiveBytesRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"tunnelip6\":\"Test\",\"tnlrxbytesrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}