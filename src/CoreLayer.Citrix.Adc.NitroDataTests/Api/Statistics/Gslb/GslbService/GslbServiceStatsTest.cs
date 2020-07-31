using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Gslb.GslbService
{
    public class GslbServiceStatsTest
    {
        [Theory]
        [ClassData(typeof(GslbServiceStatsValidationTestData))]
        public void GslbServiceStatsValidationTest(GslbServiceStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(GslbServiceStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GslbServiceStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GslbServiceStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new GslbServiceStats()
                {
                    ServiceName = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"servicename\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new GslbServiceStats()
                {
                    ServiceName = "Test",
                    RequestsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"servicename\":\"Test\",\"requestsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}