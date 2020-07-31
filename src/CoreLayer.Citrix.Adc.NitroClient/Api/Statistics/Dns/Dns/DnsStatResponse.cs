using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.Dns
{
    public class DnsStatResponse : NitroResponse
    {
        [JsonPropertyName("dns")]public DnsStats DnsStatistics { get; set; }
    }
}