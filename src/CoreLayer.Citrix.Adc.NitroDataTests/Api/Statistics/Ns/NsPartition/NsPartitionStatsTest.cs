using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsPartition
{
    public class NsPartitionStatsTest
    {
        [Theory]
        [ClassData(typeof(NsPartitionStatsValidationTestData))]
        public void NsPartitionStatsValidationTest(NsPartitionStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsPartitionStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsPartitionStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsPartitionStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsPartitionStats()
                {
                    PartitionName = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"partitionname\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsPartitionStats()
                {
                    PartitionName = "Test",
                    MemoryUsagePercent = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"partitionname\":\"Test\",\"memoryusagepcnt\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}