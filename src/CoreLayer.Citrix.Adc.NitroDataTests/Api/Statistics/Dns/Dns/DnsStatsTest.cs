using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Dns.Dns
{
    public class DnsStatsTest
    {
        [Theory]
        [ClassData(typeof(DnsStatsValidationTestData))]
        public void DnsStatsValidationTest(DnsStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(DnsStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class DnsStatsValidationTestData : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new DnsStats()
                {
                    DnsErrorNullAttack = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"dnserrnullattack\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new DnsStats()
                {
                    DnsTotalAnswers = "Test",
                    DnsQueriesRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"dnsqueriesrate\":5,\"dnstotanswers\":\"Test\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}