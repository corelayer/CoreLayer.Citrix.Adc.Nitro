using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ssl;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ssl.SslvServer
{
    public class SslvServerStatsTest
    {
        [Theory]
        [ClassData(typeof(SslvServerStatsTestData))]
        public void SslvServerStatsTests(SslvServerStats sslvServerStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(sslvServerStats, typeof(SslvServerStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class SslvServerStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SslvServerStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new SslvServerStats()
                {
                    State = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"state\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new SslvServerStats()
                {
                    State = "Test",
                    SslClientAuthSuccessRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"state\":\"Test\",\"sslclientauthsuccessrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}