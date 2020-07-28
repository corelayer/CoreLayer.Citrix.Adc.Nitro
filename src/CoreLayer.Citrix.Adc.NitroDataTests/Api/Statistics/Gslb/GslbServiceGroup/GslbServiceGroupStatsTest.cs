using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Gslb.GslbServiceGroup
{
    public class GslbServiceGroupStatsTest
    {
        [Theory]
        [ClassData(typeof(GslbServiceGroupStatsValidationTestData))]
        public void GslbServiceGroupStatsValidationTest(GslbServiceGroupStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(GslbServiceGroupStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GslbServiceGroupStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GslbServiceGroupStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new GslbServiceGroupStats()
                {
                    ServiceGroupName = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"servicegroupname\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new GslbServiceGroupStats()
                {
                    ServiceGroupName = "Test",
                    State = "5"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"servicegroupname\":\"Test\",\"state\":\"5\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}