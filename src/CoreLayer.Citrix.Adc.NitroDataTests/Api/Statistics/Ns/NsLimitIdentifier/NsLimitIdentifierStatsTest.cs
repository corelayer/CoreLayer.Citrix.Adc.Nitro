using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsLimitIdentifier
{
    public class NsLimitIdentifierStatsTest
    {
        [Theory]
        [ClassData(typeof(NsLimitIdentifierStatsValidationTestData))]
        public void NsLimitIdentifierStatsValidationTest(NsLimitIdentifierStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsLimitIdentifierStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsLimitIdentifierStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsLimitIdentifierStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsLimitIdentifierStats()
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
                new NsLimitIdentifierStats()
                {
                    Name = "Test",
                    RateLimitObjectDrops = "5"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"ratelmtobjdrops\":\"5\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}