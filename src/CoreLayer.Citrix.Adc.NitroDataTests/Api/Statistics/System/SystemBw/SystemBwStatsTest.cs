using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.System.SystemBw
{
    public class SystemBwStatsTest
    {
        [Theory]
        [ClassData(typeof(SystemBwStatsValidationTestData))]
        public void SystemBwStatsValidationTest(SystemBwStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(SystemBwStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class SystemBwStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemBwStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new SystemBwStats()
                {
                    HttpClientErrorStray = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"httpclterrstray\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new SystemBwStats()
                {
                    HttpClientErrorStray = "Test",
                    HttpClientTtlpHwmRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"httpclterrstray\":\"Test\",\"httpcltttlphwmrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}