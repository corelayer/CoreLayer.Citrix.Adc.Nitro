using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class InterfaceStats
    {
        public string Id { get; set; }
        [JsonPropertyName("curintfstate")]public string CurInterfaceState { get; set; }
        [JsonPropertyName("curlinkuptime")]public string CurrentLinkUptime { get; set; }
        [JsonPropertyName("curlinkdowntime")]public string CurrentLinkDowntime { get; set; }
        [JsonPropertyName("totrxbytes")]public string TotalReceiveBytes { get; set; }
        [JsonPropertyName("rxbytesrate")]public double? ReceiveBytesRate { get; set; }
        [JsonPropertyName("tottxbytes")]public string TotalTransmitBytes { get; set; }
        [JsonPropertyName("txbytesrate")]public double? TransmitBytesRate { get; set; }
        [JsonPropertyName("totrxpkts")]public string TotalReceivePackets { get; set; }
        [JsonPropertyName("rxpktsrate")]public double? ReceivePacketsRate { get; set; }
        [JsonPropertyName("tottxpkts")]public string TotalTransmitPackets { get; set; }
        [JsonPropertyName("txpktsrate")]public double? TransmitPacketsRate { get; set; }
        [JsonPropertyName("jumbopktsreceived")]public string JumboPacketsReceived { get; set; }
        [JsonPropertyName("jumbopktsreceivedrate")]public double? JumboPacketsReceivedRate { get; set; }
        [JsonPropertyName("jumbopktstransmitted")]public string JumboPacketsTransmitted { get; set; }
        [JsonPropertyName("jumbopktstransmittedrate")]public double? JumboPacketsTransmittedRate { get; set; }
        [JsonPropertyName("trunkpktsreceived")]public string TrunkPacketsReceived { get; set; }
        [JsonPropertyName("trunkpktsreceivedrate")]public double? TrunkPacketsReceivedRate { get; set; }
        [JsonPropertyName("trunkpktstransmitted")]public string TrunkPacketsTransmitted { get; set; }
        [JsonPropertyName("trunkpktstransmittedrate")]public double? TrunkPacketsTransmittedRate { get; set; }
        [JsonPropertyName("nictotmulticastpkts")]public string NicTotalMulticastPackets { get; set; }
        [JsonPropertyName("nicmulticastpktsrate")]public double? NicMulticastPacketsRate { get; set; }
        [JsonPropertyName("totntscalerpkts")]public string TotalNetscalerPackets { get; set; }
        [JsonPropertyName("netscalerpktsrate")]public double? NetscalerPacketsRate { get; set; }
        [JsonPropertyName("rxlacpdu")]public string ReceivedLacpdu { get; set; }
        [JsonPropertyName("rxlacpdurate")]public double? ReceiveLacpduRate { get; set; }
        [JsonPropertyName("txlacpdu")]public string TransmitLacpdu { get; set; }
        [JsonPropertyName("txlacpdurate")]public double? TransmitLacpduRate { get; set; }
        [JsonPropertyName("errpktrx")]public string ErrorPacketReceive { get; set; }
        [JsonPropertyName("errpktrxrate")]public double? ErrorPacketReceiveRate { get; set; }
        [JsonPropertyName("errpkttx")]public string ErrorPacketTransmit { get; set; }
        [JsonPropertyName("errpkttxrat")]public double? ErrorPacketTransmitRate { get; set; }
        [JsonPropertyName("errifindiscards")]public string ErrorIfInDiscards { get; set; }
        [JsonPropertyName("errifindiscardsrate")]public double? ErrorIfInDiscardsRate { get; set; }
        [JsonPropertyName("nicerrifoutdiscards")]public string NicErrorIfOutDiscards { get; set; }
        [JsonPropertyName("nicerrifoutdiscardsrate")]public double? NicErrorIfOutDiscardsRate { get; set; }
        [JsonPropertyName("errdroppedrxpkts")]public string ErrorDroppedReceivePackets { get; set; }
        [JsonPropertyName("errdroppedrxpktsrate")]public double? ErrorDroppedReceivePacketsRate { get; set; }
        [JsonPropertyName("errdroppedtxpkts")]public string ErrorDroppedTransmitPackets { get; set; }
        [JsonPropertyName("errdroppedtxpktsrate")]public double? ErrorDroppedTransmitPacketsRate { get; set; }
        [JsonPropertyName("errlinkhangs")]public string ErrorLinkHangs { get; set; }
        [JsonPropertyName("nicstsstalls")]public string NicStatusStalls { get; set; }
        [JsonPropertyName("nixtxstalls")]public string NicTransmitStalls { get; set; }
        [JsonPropertyName("nicrxstalls")]public string NicReceiveStalls { get; set; }
        [JsonPropertyName("nicerrdisables")]public string NicErrorDisables { get; set; }
        [JsonPropertyName("linkreinits")]public string LinkReinitialized { get; set; }
        [JsonPropertyName("totmacmoved")]public string TotalMacMoved { get; set; }
        public double? MacMovedRate { get; set; }
        [JsonPropertyName("errnicmuted")]public string ErrorNicMuted { get; set; }
        [JsonPropertyName("rxcrcerrors")]public string ReceivedCrcErrors { get; set; }
        [JsonPropertyName("rxcrcerrorsrate")]public double? ReceivedCrcErrorsRate { get; set; }
        public string InterfaceAlias { get; set; }
        [JsonPropertyName("curlinkstate")]public string CurrentLinkState { get; set; }
        
    }
}