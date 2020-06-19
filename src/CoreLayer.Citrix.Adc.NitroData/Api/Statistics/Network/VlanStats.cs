using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class VlanStats
    {
        public string Id { get; set; }
        [JsonPropertyName("vlantotrxpkts")]public string VlanTotalReceivePackets { get; set; }
        [JsonPropertyName("vlanrxpktsrate")]public double? VlanReceivePacketsRate { get; set; }
        [JsonPropertyName("vlantotrxbytes")]public string VlanTotalReceiveBytes { get; set; }
        [JsonPropertyName("vlanrxbytesrate")]public double? VlanReceiveBytesRate { get; set; }
        [JsonPropertyName("vlantottxpkts")]public string VlanTotalTransmitPackets { get; set; }
        [JsonPropertyName("vlantxpktsrate")]public double? VlanTransmitPacketsRate { get; set; }
        [JsonPropertyName("vlantottxbytes")]public string VlanTotalTransmitBytes { get; set; }
        [JsonPropertyName("vlantxbytesrate")]public double? VlanTransmitBytesRate { get; set; }
        [JsonPropertyName("vlantotaldroppedpkts")]public string VlanTotalDroppedPackets { get; set; }
        [JsonPropertyName("vlantotbroadcastpkts")]public string VlanTotalBroadcastPackets { get; set; }
        
    }
}