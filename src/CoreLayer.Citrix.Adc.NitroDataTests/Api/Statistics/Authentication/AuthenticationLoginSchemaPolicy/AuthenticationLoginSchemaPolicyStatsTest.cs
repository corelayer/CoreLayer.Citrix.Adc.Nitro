using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Authentication.AuthenticationLoginSchemaPolicy
{
    public class AuthenticationLoginSchemaPolicyStatsTest
    {
        [Theory]
        [ClassData(typeof(AuthenticationLoginSchemaPolicyStatsTestData))]
        public void AuthenticationLoginSchemaPolicyStatsValidationTest(AuthenticationLoginSchemaPolicyStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AuthenticationLoginSchemaPolicyStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AuthenticationLoginSchemaPolicyStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AuthenticationLoginSchemaPolicyStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AuthenticationLoginSchemaPolicyStats()
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
                new AuthenticationLoginSchemaPolicyStats()
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