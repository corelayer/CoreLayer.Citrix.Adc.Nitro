using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsMemory
{
    public class NsMemoryStatsTest
    {
        [Theory]
        [ClassData(typeof(NsMemoryStatValidationTestData))]
        public void NsMemoryStatsValidationTest(NsMemoryStats stats, Dictionary<string, string> expected)
        {
             Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsMemoryStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsMemoryStatValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsMemoryStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsMemoryStats()
                {
                    Pool = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"pool\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsMemoryStats()
                {
                    Pool = "Test",
                    MemoryCurrentFeatureAllocatedPercent = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"pool\":\"Test\",\"memcurallocper\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}