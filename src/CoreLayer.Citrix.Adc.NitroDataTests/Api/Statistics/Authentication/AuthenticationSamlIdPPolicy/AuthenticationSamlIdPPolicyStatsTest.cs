using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Authentication.AuthenticationSamlIdPPolicy
{
    public class AuthenticationSamlIdPPolicyStatsTest 
    {
        [Theory]
        [ClassData(typeof(AuthenticationSamlIdPPolicyStatsValidationTestData))]
        public void AuthenticationSamlIdPPolicyStatsvalidationTest(AuthenticationSamlIdPPolicyStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AuthenticationSamlIdPPolicyStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AuthenticationSamlIdPPolicyStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        { 
            yield return new object[]
            {
                new AuthenticationSamlIdPPolicyStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AuthenticationSamlIdPPolicyStats()
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
                new AuthenticationSamlIdPPolicyStats()
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