using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.DnsRecords
{
    public class DnsRecordsStatResponse : NitroResponse
    {
        [JsonPropertyName("dnsrecords")]public DnsRecordsStats DnsRecordsStatistics { get; set; }
    }
}