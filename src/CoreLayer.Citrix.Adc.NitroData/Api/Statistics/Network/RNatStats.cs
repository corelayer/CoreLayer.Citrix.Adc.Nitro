using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class RNatStats
    {
        [JsonPropertyName("rnatcursessions")]public string RNatCurrentSessions { get; set; }
        [JsonPropertyName("rnattottxpkts")]public string RNatTotalTransmitPackets { get; set; }
        [JsonPropertyName("rnattxpktsrate")]public double? RNatTransmitPacketsRate { get; set; }
        [JsonPropertyName("rnattotrxpkts")]public string RNatTotalReceivePackets { get; set; }
        [JsonPropertyName("rnatrxpktsrate")]public double? RNatReceivePacketsRate { get; set; }
        [JsonPropertyName("rnattotrxbytes")]public string RNatTotalReceiveBytes { get; set; }
        [JsonPropertyName("rnatrxbytesrate")]public double? RNatReceiveBytesRate { get; set; }
        [JsonPropertyName("rnattottxbytes")]public string RNatTotalTransmitBytes { get; set; }
        [JsonPropertyName("rnattxbytesrate")]public double? RNatTransmitBytesRate { get; set; }
        [JsonPropertyName("rnattottxsyn")]public string RNatTotalConnectionRequests { get; set; }
        [JsonPropertyName("rnattxsynrate")]public double? RNatConnectionRequestsRate { get; set; }
    }
}