using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Aaa;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Aaa.Aaa
{
    public class AaaStatsTest
    {
        [Theory]
        [ClassData(typeof(AaaStatsTestData))]
        public void AaaStatsTests(AaaStats aaaStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(aaaStats, typeof(AaaStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AaaStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AaaStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AaaStats()
                {
                    AaaCurrentTmSessions = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"aaacurtmsessions\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new AaaStats()
                {
                    AaaCurrentTmSessions = "Test",
                    AaaCurrentTmSessionsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"aaacurtmsessions\":\"Test\",\"aaacurtmsessionsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}