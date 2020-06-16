using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.System.SystemCpu
{
    public class SystemCpuStatsTest
    {
        [Theory]
        [ClassData(typeof(SystemCpuStatsTestData))]
        public void SystemCpuStatsTests(SystemCpuStats systemCpuStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemCpuStats, typeof(SystemCpuStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class SystemCpuStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemCpuStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new SystemCpuStats()
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
                new SystemCpuStats()
                {
                    Id = "Test",
                    PerCpuUse = "5"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"id\":\"Test\",\"percpuuse\":\"5\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}