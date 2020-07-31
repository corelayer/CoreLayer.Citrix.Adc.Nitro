using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.AppFirewall;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.AppFirewall.AppFwPolicy
{
    public class AppFwPolicyStatsTest
    {
        [Theory]
        [ClassData(typeof(AppFwPolicyStatsValidationTestData))]
        public void AppFwStatsValidationTest(AppFwPolicyStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AppFwPolicyStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AppFwPolicyStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AppFwPolicyStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AppFwPolicyStats()
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
                new AppFwPolicyStats()
                {
                    Name = "Test",
                    PolicyHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"pipolicyhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}