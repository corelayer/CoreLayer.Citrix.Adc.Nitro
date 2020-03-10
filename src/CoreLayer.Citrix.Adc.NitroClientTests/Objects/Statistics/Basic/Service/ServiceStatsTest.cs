using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Objects.Statistics.Basic.Service
{
    public class ServiceStatsTest
    {
        [Theory]
        [ClassData(typeof(ServiceStatsTestData))]
        public void ServiceStatsValidationTest(ServiceStatistics serviceStatistics, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(serviceStatistics, typeof(ServiceStatistics), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServiceStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                
                new ServiceStatistics()
                {
                    
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{}"}
                }, 
            };
            yield return new object[]
            {
                new ServiceStatistics()
                {
                    Name = "test"
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{\"name\":\"test\"}"}
                }, 
            };
            yield return new object[]
            {
                new ServiceStatistics()
                {
                    Name = "Test",
                    AverageServerTimeToFirstByte = "10"
                }, 
                new Dictionary<string, string>()
                {
                    {"ContentString", "{\"name\":\"Test\",\"avgsvrttfb\":\"10\"}"}
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}