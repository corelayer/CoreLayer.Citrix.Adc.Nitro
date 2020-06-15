using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.Ns
{
    public class NsStatsTest
    {
        [Theory]
        [ClassData(typeof(NsStatsTestData))]
        public void NsStatsTests(NsStats nsStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nsStats, typeof(NsStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsStats()
                {
                    ResCpuUsage = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"rescpuusage\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsStats()
                {
                    ResCpuUsage = "Test",
                    CacheHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"rescpuusage\":\"Test\",\"cachehitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}