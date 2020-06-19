using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.System.System
{
    public class SystemStatsTest
    {
        [Theory]
        [ClassData(typeof(SystemStatsTestsData))]
        public void SystemStatsTests(SystemStats systemStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemStats, typeof(SystemStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class SystemStatsTestsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new SystemStats()
                {
                    NumberOfCpus = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"numcpus\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new SystemStats()
                {
                    NumberOfCpus = "Test",
                    Disk1Size = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"numcpus\":\"Test\",\"disk1size\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}