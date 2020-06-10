using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Basic.ServicegroupMember
{
    public class ServicegroupMemberStatsTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupMemberStatsTestData))]
        public void ServicegroupMemberStatsValidationTest(ServicegroupMemberStatistics servicegroupMemberStatistics, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(servicegroupMemberStatistics, typeof(ServicegroupMemberStatistics), NitroServiceSerializerOptions.JsonSerializerOptions));
        }

    }
    public class ServicegroupMemberStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupMemberStatistics()
                {
                    
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{}"}
                }, 
            };
            yield return new object[]
            {
                new ServicegroupMemberStatistics()
                {
                    ServicegroupName = "test"
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{\"servicegroupname\":\"test\"}"}
                }, 
            };
            yield return new object[]
            {
                new ServicegroupMemberStatistics()
                {
                    ServicegroupName = "Test",
                    ServiceType = "TestType",
                    State = "ENABLED"
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{\"servicegroupname\":\"Test\",\"servicetype\":\"TestType\",\"state\":\"ENABLED\"}"}
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}