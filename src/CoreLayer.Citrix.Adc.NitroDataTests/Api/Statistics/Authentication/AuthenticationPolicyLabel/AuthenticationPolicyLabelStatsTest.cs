using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Authentication.AuthenticationPolicyLabel
{
    public class AuthenticationPolicyLabelStatsTest
    {
        [Theory]
        [ClassData(typeof(AuthenticationPolicyLabelStatsValidationTestData))]
        public void AuthenticationPolicyLabelStatsValidationTest(AuthenticationPolicyLabelStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AuthenticationPolicyLabelStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AuthenticationPolicyLabelStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AuthenticationPolicyLabelStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AuthenticationPolicyLabelStats()
                {
                    PolicyLabelHits = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"pipolicylabelhits\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new AuthenticationPolicyLabelStats()
                {
                    PolicyLabelHits = "Test",
                    PolicyLabelHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"pipolicylabelhits\":\"Test\",\"pipolicylabelhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}