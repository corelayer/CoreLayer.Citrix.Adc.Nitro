using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.Vxlan
{
    public class VxlanStatsTest
    {
        [Theory]
        [ClassData(typeof(VxlanStatsValidationTestData))]
        public void VxlanStatsValidationTest(VxlanStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(VxlanStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class VxlanStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VxlanStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new VxlanStats()
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
                new VxlanStats()
                {
                    Id = "Test",
                    VxlanTransmitPacketsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"id\":\"Test\",\"vxlantxpktsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}