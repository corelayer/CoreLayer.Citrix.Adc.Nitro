using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.ContentSwitching.Csvserver
{
    public class CsvserverStatsTest
    {
        [Theory]
        [ClassData(typeof(CsvserverStatsTestData))]
        public void LbvserverStatsValidationTest(CsvserverStats css, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(css, typeof(CsvserverStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsvserverStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsvserverStats()
                {
                    Name = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new CsvserverStats()
                {
                    Name = "Test",
                    CurrentMultipathTcpSessions = "5"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"curmptcpsessions\":\"5\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}