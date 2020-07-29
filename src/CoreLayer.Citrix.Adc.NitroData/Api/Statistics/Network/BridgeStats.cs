using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class BridgeStats
    {
        [JsonPropertyName("tcptotbdgmacmoved")]public string TcpTotalBridgeMacMoved { get; set; }
        [JsonPropertyName("tcpbdgmacmovedrate")]public double? TcpBridgeMacMovedRate { get; set; }
        [JsonPropertyName("tcptotbdgcollisions")]public string TcpTotalBridgingTableCollisions { get; set; }
        [JsonPropertyName("tcpbdgcollisionsrate")]public double? TcpBridgingTableCollisionsRate { get; set; }
        [JsonPropertyName("tcperrbdgmuted")]public string TcpErrorBridgeMuted { get; set; }
        [JsonPropertyName("tcperrbdgmutedrate")]public double? TcpErrorBridgeMutedRate { get; set; }
        [JsonPropertyName("totbdgpkts")]public string TotalBridgedPackets { get; set; }
        [JsonPropertyName("bdgpktsrate")]public double? BridgedPacketsRate { get; set; }
        [JsonPropertyName("totbdgmbits")]public string TotalBridgedMbits { get; set; }
        [JsonPropertyName("bdgmbitsrate")]public double? BridgedMbitsRate { get; set; }
    }
}