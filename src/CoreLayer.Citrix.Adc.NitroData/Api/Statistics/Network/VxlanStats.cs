using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class VxlanStats
    {
        public string Id { get; set; }
        [JsonPropertyName("vxlanrxbytesrate")]public double? VxlanReceiveBytesRate { get; set; }
        [JsonPropertyName("vxlantottxpkts")]public string VxlanTotalTransmitPackets { get; set; }
        [JsonPropertyName("vxlanrxpktsrate")]public double? VxlanReceivePacketsRate { get; set; }
        [JsonPropertyName("vxlantotrxbytes")]public string VxlanTotalReceiveBytes { get; set; }
        [JsonPropertyName("vxlantxbytesrate")]public double? VxlanTransmitBytesRate { get; set; }
        [JsonPropertyName("vxlantxpktsrate")]public double? VxlanTransmitPacketsRate { get; set; }
        [JsonPropertyName("vxlantottxbytes")]public string VxlanTotalTransmitBytes { get; set; }
        [JsonPropertyName("vxlantotrxpkts")]public string VxlanTotalReceivePackets { get; set; }
    }
}