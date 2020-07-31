using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Vpn.Vpn
{
    public class VpnStatsTest
    {
        [Theory]
        [ClassData(typeof(VpnStatsValidationTestData))]
        public void VpnStatsValidationTest(VpnStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(VpnStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class VpnStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VpnStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new VpnStats()
                {
                    IndexHtmlHit = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"indexhtmlhit\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new VpnStats()
                {
                    IndexHtmlHit = "Test",
                    DnsRequestHitRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"indexhtmlhit\":\"Test\",\"dnsreqhitrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}