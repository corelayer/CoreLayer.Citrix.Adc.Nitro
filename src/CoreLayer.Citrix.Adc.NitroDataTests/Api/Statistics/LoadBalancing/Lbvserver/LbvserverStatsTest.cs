using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.LoadBalancing;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.LoadBalancing.Lbvserver
{
    public class LbvserverStatsTest
    {
        [Theory]
        [ClassData(typeof(LbvserverStatsTestData))]
        public void LbvserverStatsValidationTest(LbvserverStats lbs, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(lbs, typeof(LbvserverStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class LbvserverStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new LbvserverStats()
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
                new LbvserverStats()
                {
                    Name = "Test",
                    InactiveServices = "5"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"inactsvcs\":\"5\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}