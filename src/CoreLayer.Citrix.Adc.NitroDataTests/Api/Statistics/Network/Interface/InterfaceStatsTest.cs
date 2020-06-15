using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.Interface
{
    public class InterfaceStatsTest
    {
        [Theory]
        [ClassData(typeof(InterfaceStatsTestData))]
        public void InterfaceStatsTests(InterfaceStats interfaceStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(interfaceStats, typeof(InterfaceStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class InterfaceStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        { 
            yield return new object[]
            {
                new InterfaceStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new InterfaceStats()
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
                new InterfaceStats()
                {
                    Id = "Test",
                    RxBytesRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"id\":\"Test\",\"rxbytesrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}