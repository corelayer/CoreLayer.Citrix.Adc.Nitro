using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Gslb.GslbServiceGroupMember
{
    public class GslbServiceGroupMemberStatsTest
    {
        [Theory]
        [ClassData(typeof(GslbServiceGroupMemberStatsValidationTestData))]
        public void GslbServiceGroupMemberStatsValidationTest(GslbServiceGroupMemberStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(GslbServiceGroupMemberStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GslbServiceGroupMemberStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GslbServiceGroupMemberStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new GslbServiceGroupMemberStats()
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
                new GslbServiceGroupMemberStats()
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