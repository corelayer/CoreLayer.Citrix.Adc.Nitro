using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.System.SystemMemory
{
    public class SystemMemoryStatsTest
    {
        [Theory]
        [ClassData(typeof(SystemMemoryStatsTestData))]
        public void SystemMemoryStatsTests(SystemMemoryStats systemMemoryStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemMemoryStats, typeof(SystemMemoryStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class SystemMemoryStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemMemoryStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new SystemMemoryStats()
                {
                    MemoryTotalInMb = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"memtotinmb\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new SystemMemoryStats()
                {
                    MemoryTotalFree = "Test",
                    MemoryTotalAllocatedPercent = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"memtotfree\":\"Test\",\"memtotallocpcnt\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}