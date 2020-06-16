using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class InterfaceStats
    {
        public string Id { get; set; }
        [JsonPropertyName("curintfstate")]public string CurInterfaceState { get; set; }
        public string CurLinkUptime { get; set; }
        public string CurLinkDowntime { get; set; }
        [JsonPropertyName("totrxbytes")]public string TotReceiveBytes { get; set; }
        [JsonPropertyName("rxbytesrate")]public double? ReceiveBytesRate { get; set; }
        [JsonPropertyName("tottxbytes")]public string TotTransmitBytes { get; set; }
        [JsonPropertyName("txbytesrate")]public double? TransmitBytesRate { get; set; }
        [JsonPropertyName("totrxpkts")]public string TotReceivePackets { get; set; }
        [JsonPropertyName("rxpktsrate")]public double? ReceivePacketsRate { get; set; }
        [JsonPropertyName("tottxpkts")]public string TotTransmitPackets { get; set; }
        [JsonPropertyName("txpktsrate")]public double? TransmitPacketsRate { get; set; }
        public string JumboPktsReceived { get; set; }
        public double? JumboPktsReceivedRate { get; set; }
        public string JumboPktsTransmitted { get; set; }
        public double? JumboPktsTransmittedRate { get; set; }
        public string TrunkPktsReceived { get; set; }
        public double? TrunkPktsReceivedRate { get; set; }
        public string TrunkPktTransmitted { get; set; }
        public double? TrunkPktsTransmittedRate { get; set; }
        public string NicTotMulticastPkts { get; set; }
        public double? NicMultiCastPktsRate { get; set; }
        public string TotNetscalerPkts { get; set; }
        public double? NetscalerPktsRate { get; set; }
        [JsonPropertyName("rxlacpdu")]public string ReceiveLacpdu { get; set; }
        [JsonPropertyName("rxlacpdurate")]public double? ReceiveLacpduRate { get; set; }
        [JsonPropertyName("txlacpdu")]public string TransmitLacpdu { get; set; }
        [JsonPropertyName("txlacpdurate")]public double? TransmitLacpduRate { get; set; }
        [JsonPropertyName("errpktrx")]public string ErrorPacketReceive { get; set; }
        [JsonPropertyName("errpktrxrate")]public double? ErrorPacketReceiveRate { get; set; }
        [JsonPropertyName("errpkttx")]public string ErrorPacketTransmit { get; set; }
        [JsonPropertyName("errpkttxrat")]public double? ErrorPacketTransmitRate { get; set; }
        public string ErrIfInDiscards { get; set; }
        public double? ErrIfInDiscardsRate { get; set; }
        public string NicErrIfOutDiscards { get; set; }
        public double? NicErrIfOutDiscardsRate { get; set; }
        [JsonPropertyName("errdroppedrxpkts")]public string ErrDroppedReceivePkts { get; set; }
        [JsonPropertyName("errdroppedrxpktsrate")]public double? ErrDroppedReceivePktsRate { get; set; }
        [JsonPropertyName("errdroppedtxpkts")]public string ErrDroppedTransmitPkts { get; set; }
        [JsonPropertyName("errdroppedtxpktsrate")]public double? ErrDroppedTransmitPktsRate { get; set; }
        public string ErrLinkHangs { get; set; }
        [JsonPropertyName("nicstsstalls")]public string NicStatusStalls { get; set; }
        [JsonPropertyName("nixtxstalls")]public string NicTransmitStalls { get; set; }
        [JsonPropertyName("nicrxstalls")]public string NicReceiveStalls { get; set; }
        public string NicerrDisables { get; set; }
        public string LinkReinits { get; set; }
        public string TotMacMoved { get; set; }
        public double? MacMovedRate { get; set; }
        public string ErrNicMuted { get; set; }
        public string RxCrcErrors { get; set; }
        public double? RxCrcErrorsRate { get; set; }
        public string InterfaceAlias { get; set; }
        public string CurLinkState { get; set; }
        
    }
}