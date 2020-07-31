using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class RNat6Stats
    {
        [JsonPropertyName("rnat6cursessions")]public string RNat6CurrentSessions { get; set; }
        [JsonPropertyName("rnat6tottxpkts")]public string RNat6TotalTransmitPackets { get; set; }
        [JsonPropertyName("rnat6txpktsrate")]public double? RNat6TransmitPacketsRate { get; set; }
        [JsonPropertyName("rnat6totrxpkts")]public string RNat6TotalReceivePackets { get; set; }
        [JsonPropertyName("rnat6rxpktsrate")]public double? RNat6ReceivePacketsRate { get; set; }
        [JsonPropertyName("rnat6totrxbytes")]public string RNat6TotalReceiveBytes { get; set; }
        [JsonPropertyName("rnat6rxbytesrate")]public double? RNat6ReceiveBytesRate { get; set; }
        [JsonPropertyName("rnat6tottxbytes")]public string RNat6TotalTransmitBytes { get; set; }
        [JsonPropertyName("rnat6txbytesrate")]public double? RNat6TransmitBytesRate { get; set; }
        [JsonPropertyName("rnat6tottxsyn")]public string RNat6TotalConnectionRequests { get; set; }
        [JsonPropertyName("rnat6txsynrate")]public double? RNat6ConnectionRequestsRate { get; set; }
    }
}