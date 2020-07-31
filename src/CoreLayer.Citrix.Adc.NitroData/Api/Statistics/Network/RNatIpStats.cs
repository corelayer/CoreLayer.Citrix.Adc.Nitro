using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class RNatIpStats
    {
        [JsonPropertyName("Rnatip")]public string RNatIp { get; set; }
        [JsonPropertyName("iprnatcursessions")]public string IpRNatCurrentSessions { get; set; }
        [JsonPropertyName("iptd")]public string IpTrafficDomain { get; set; }
        [JsonPropertyName("iprnattxpktsrate")]public double? IpRNatTransmitPacketsRate { get; set; }
        [JsonPropertyName("iprnattottxpkts")]public string IpRNatTotalTransmitPackets { get; set; }
        [JsonPropertyName("iprnatrxpktsrate")]public double? IpRNatReceivePacketsRate { get; set; }
        [JsonPropertyName("iprnattotrxpkts")]public string IpRNatTotalReceivePackets { get; set; }
        [JsonPropertyName("iprnattottxbytes")]public string IpRNatTotalTransmitBytes { get; set; }
        [JsonPropertyName("iprnattxbytesrate")]public double? IpRNatTransmitBytesRate { get; set; }
        [JsonPropertyName("iprnattotrxbytes")]public string IpRNatTotalReceiveBytes { get; set; }
        [JsonPropertyName("iprnatrxbytesrate")]public double? IpRNatReceiveBytesRate { get; set; }
        [JsonPropertyName("iprnattottxsyn")]public string IpRNatTotalConnectionRequests { get; set; }
        [JsonPropertyName("iprnattxsynrate")]public double? IpRNatConnectionRequestsRate { get; set; }
    }
}