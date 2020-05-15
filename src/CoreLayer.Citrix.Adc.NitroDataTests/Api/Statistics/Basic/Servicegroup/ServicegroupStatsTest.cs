using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Basic.Servicegroup
{
    public class ServicegroupStatsTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupStatsTestData))]
        public void ServiceStatsValidationTest(ServicegroupStatistics servicegroupStatistics, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(servicegroupStatistics, typeof(ServicegroupStatistics), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServicegroupStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupStatistics()
                {
                    
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{}"}
                }, 
            };
            yield return new object[]
            {
                new ServicegroupStatistics()
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
                new ServicegroupStatistics()
                {
                    ServicegroupName = "Test",
                    ServiceType = "TestType",
                    State = "ENABLED"
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{\"servicegroupname\":\"Test\",\"state\":\"ENABLED\",\"servicetype\":\"TestType\"}"}
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}