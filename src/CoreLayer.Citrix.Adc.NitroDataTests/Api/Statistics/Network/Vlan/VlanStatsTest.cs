using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.Vlan
{
    public class VlanStatsTest
    {
        [Theory]
        [ClassData(typeof(VlanStatsTestData))]
        public void VlanStatsTests(VlanStats vlanStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(vlanStats, typeof(VlanStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class VlanStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VlanStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new VlanStats()
                {
                    Id = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"id\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new VlanStats()
                {
                    Id = "Test",
                    VlanTransmitPacketsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"id\":\"Test\",\"vlantxpktsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}