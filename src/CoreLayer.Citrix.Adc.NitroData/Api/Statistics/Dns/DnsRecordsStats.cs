using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns
{
    public class DnsRecordsStats
    {
        public string DnsRecordType { get; set; }
        [JsonPropertyName("dnscurentries")]public string DnsCurrentEntries { get; set; }
        [JsonPropertyName("dnstotupdates")]public string DnsTotalUpdates { get; set; }
        [JsonPropertyName("dnstotrequests")]public string DnsTotalRequests { get; set; }
        [JsonPropertyName("dnstoterraliasex")]public string DnsTotalErrorAliasExists { get; set; }
        [JsonPropertyName("dnstoterrrespform")]public string DnsTotalErrorResponseForm { get; set; }
        [JsonPropertyName("dnstotentries")]public string DnsTotalEntries { get; set; }
        [JsonPropertyName("dnscurrecords")]public string DnsCurrentRecords { get; set; }
        [JsonPropertyName("dnstoterrnodomains")]public string DnsTotalErrorNoDomains { get; set; }
        [JsonPropertyName("dnstoterrlimits")]public string DnsTotalErrorLimits { get; set; }
        [JsonPropertyName("dnstotresponses")]public string DnsTotalResponses { get; set; }
    }
}