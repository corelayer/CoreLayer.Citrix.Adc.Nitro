using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class TunnelIp6Stats
    {
        public string TunnelIp6 { get; set; }
        [JsonPropertyName("tnltotrxpkts")]public string TunnelTotalReceivePackets { get; set; }
        [JsonPropertyName("tnlrxpktsrate")]public double? TunnelReceivePacketsRate { get; set; }
        [JsonPropertyName("tnltottxpkts")]public string TunnelTotalTransmitPackets { get; set; }
        [JsonPropertyName("tnltxpktsrate")]public double? TunnelTransmitPacketsRate { get; set; }
        [JsonPropertyName("tnltottxbytes")]public string TunnelTotalTransmitBytes { get; set; }
        [JsonPropertyName("tnltxbytesrate")]public double? TunnelTransmitBytesRate { get; set; }
        [JsonPropertyName("tnltotrxbytes")]public string TunnelTotalReceiveBytes { get; set; }
        [JsonPropertyName("tnlrxbytesrate")]public double? TunnelReceiveBytesRate { get; set; }
    }
}