using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsPbr
{
    public class NsPbrStatsTest
    {
        [Theory]
        [ClassData(typeof(NsPbrStatsValidationTestData))]
        public void NsPbrStatsValidationTest(NsPbrStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsPbrStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsPbrStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsPbrStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsPbrStats()
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
                new NsPbrStats()
                {
                    Name = "Test",
                    PbrHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"pbrperhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}