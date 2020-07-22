using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Authentication.AuthenticationOAuthIdPPolicy
{
    public class AuthenticationOAuthIdPPolicyStatsTest
    {
        [Theory]
        [ClassData(typeof(AuthenticationOAuthIdPPolicyStatsTestData))]
        public void AuthenticationOAuthIdPPolicyStatsValidationTest(AuthenticationOAuthIdPPolicyStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AuthenticationOAuthIdPPolicyStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AuthenticationOAuthIdPPolicyStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AuthenticationOAuthIdPPolicyStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AuthenticationOAuthIdPPolicyStats()
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
                new AuthenticationOAuthIdPPolicyStats()
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