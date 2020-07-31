using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Authentication.AuthenticationPolicy
{
    public class AuthenticationPolicyStatsTest
    {
        [Theory]
        [ClassData(typeof(AuthenticationPolicyStatsValidationTestData))]
        public void AuthenticationPolicyStatsValidationTest(AuthenticationPolicyStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AuthenticationPolicyStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AuthenticationPolicyStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AuthenticationPolicyStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AuthenticationPolicyStats()
                {
                    PolicyHits = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"pipolicyhits\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new AuthenticationPolicyStats()
                {
                    PolicyHits = "Test",
                    PolicyHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"pipolicyhits\":\"Test\",\"pipolicyhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}