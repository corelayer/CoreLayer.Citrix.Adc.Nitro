using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class VlanStats
    {
        public string Id { get; set; }
        [JsonPropertyName("vlantotrxpkts")]public string VlanTotReceivePkts { get; set; }
        [JsonPropertyName("vlanrxpktsrate")]public double? VlanReceivePktsRate { get; set; }
        [JsonPropertyName("vlantotrxbytes")]public string VlanTotReceiveBytes { get; set; }
        [JsonPropertyName("vlanrxbytesrate")]public double? VlanReceiveBytesRate { get; set; }
        [JsonPropertyName("vlantottxpkts")]public string VlanTotTransmitPkts { get; set; }
        [JsonPropertyName("vlantxpktsrate")]public double? VlanTransmitPktsRate { get; set; }
        [JsonPropertyName("vlantottxbytes")]public string VlanTotTransmitBytes { get; set; }
        [JsonPropertyName("vlantxbytesrate")]public double? VlanTransmitBytesRate { get; set; }
        public string VlanTotDroppedPkts { get; set; }
        public string VlanTotBroadcastPkts { get; set; }
        
    }
}