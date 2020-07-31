using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Dns.DnsRecords
{
    public class DnsRecordsStatsTest
    {
        [Theory]
        [ClassData(typeof(DnsRecordsStatsValidationTestData))]
        public void DnsRecordsStatsValidationTest(DnsRecordsStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(DnsRecordsStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class DnsRecordsStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsRecordsStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new DnsRecordsStats()
                {
                    DnsRecordType = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"dnsrecordtype\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new DnsRecordsStats()
                {
                    DnsRecordType = "Test",
                    DnsTotalEntries = "5"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"dnsrecordtype\":\"Test\",\"dnstotentries\":\"5\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}