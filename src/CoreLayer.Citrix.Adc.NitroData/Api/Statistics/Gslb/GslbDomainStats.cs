using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb
{
    public class GslbDomainStats
    {
        public string Name { get; set; }
        [JsonPropertyName("dnstotalqueries")]public string DnsTotalQueries { get; set; }
        [JsonPropertyName("dnsqueriesrate")]public double? DnsQueriesRate { get; set; }
        [JsonPropertyName("gslbdnsrectype")]public string GlobalServerLoadBalancingDnsRecordType { get; set; }
    }
}