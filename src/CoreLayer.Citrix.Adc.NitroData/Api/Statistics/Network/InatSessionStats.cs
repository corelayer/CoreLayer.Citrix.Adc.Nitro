using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class InatSessionStats
    {
        public string Name { get; set; }
        [JsonPropertyName("globalinatreceivebytes")]public string GlobalInatReceiveBytes { get; set; }
        [JsonPropertyName("globalinatcursessions")]public string GlobalInatCurrentSessions { get; set; }
        [JsonPropertyName("inattotsentbytes")]public string InatTotalSentBytes { get; set; }
        [JsonPropertyName("globalinatpktsent")]public string GlobalInatPacketSent { get; set; }
        [JsonPropertyName("inatreceivebytesrate")]public double? InatReceiveBytesRate { get; set; }
        [JsonPropertyName("globalinatsentbytesrate")]public double? GlobalInatSentBytesRate { get; set; }
        [JsonPropertyName("globalinatcursessionsrate")]public double? GlobalInatCurrentSessionsRate { get; set; }
        [JsonPropertyName("inathitsrate")]public double? InatHitsRate { get; set; }
        [JsonPropertyName("inattotreceivebytes")]public string InatTotalReceiveBytes { get; set; }
        [JsonPropertyName("inatcursessionsrate")]public double? InatCurrentSessionsRate { get; set; }
        [JsonPropertyName("globalinatreceivebytesrate")]public double? GlobalInatReceiveBytesRate { get; set; }
        [JsonPropertyName("globalinatpktsentrate")]public double? GlobalInatPacketSentRate { get; set; }
        [JsonPropertyName("inatcursessions")]public string InatCurrentSessions { get; set; }
        [JsonPropertyName("inatsentbytesrate")]public double? InatSentBytesRate { get; set; }
        [JsonPropertyName("globalinattotsentbytes")]public string GlobalInatTotalSentBytes { get; set; }
        [JsonPropertyName("globalinathits")]public string GlobalInatHits { get; set; }
        [JsonPropertyName("globalinathitsrate")]public double? GlobalInatHitsRate { get; set; }
        [JsonPropertyName("inatpktsentrate")]public double? InatPacketSentRate { get; set; }
        [JsonPropertyName("globalinatpktreceived")]public string GlobalInatPacketReceived { get; set; }
        [JsonPropertyName("globalinatpktreceivedrate")]public double? GlobalInatPacketReceivedRate { get; set; }
        [JsonPropertyName("inattotpktreceived")]public string InatTotalPacketReceived { get; set; }
        [JsonPropertyName("inattothits")]public string InatTotalHits { get; set; }
        [JsonPropertyName("inattotpktsent")]public string InatTotalPacketSent { get; set; }
        [JsonPropertyName("inatpktreceivedrate")]public double? InatPacketReceivedRate { get; set; }
        
    }
}