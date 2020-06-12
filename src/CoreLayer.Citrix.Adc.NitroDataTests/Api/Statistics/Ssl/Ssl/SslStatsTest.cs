using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ssl;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ssl.Ssl
{
    public class SslStatsTest
    {
        [Theory]
        [ClassData(typeof(SslStatsTestData))]
        public void SslStatsTests(SslStats sslStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(sslStats, typeof(SslStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class SslStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SslStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new SslStats()
                {
                    Sslcursessions = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sslcursessions\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new SslStats()
                {
                    Sslcursessions = "Test",
                    Sslcursessionsrate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sslcursessions\":\"Test\",\"pipolicylabelhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}