namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class InterfaceStats
    {
        public string Id { get; set; }
        public string CurIntfState { get; set; }
        public string CurLinkUptime { get; set; }
        public string CurLinkDowntime { get; set; }
        public string TotRxBytes { get; set; }
        public double? RxBytesRate { get; set; }
        public string TotTxBytes { get; set; }
        public double? TxBytesRate { get; set; }
        public string TotRxPkts { get; set; }
        public double? RxPktsRate { get; set; }
        public string TotTxPkts { get; set; }
        public double? TxPktsRate { get; set; }
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
        public string RxLacpdu { get; set; }
        public double? RxLacpduRate { get; set; }
        public string TxLacpdu { get; set; }
        public double? TxLacpduRate { get; set; }
        public string ErrPktRx { get; set; }
        public double? ErrPktRxRate { get; set; }
        public string ErrPktTx { get; set; }
        public double? ErrPktTxRate { get; set; }
        public string ErrIfindiscards { get; set; }
        public double? ErrIfindiscardsRate { get; set; }
        public string NicErrIfoutdiscards { get; set; }
        public double? NicErrIfoutdiscardsRate { get; set; }
        public string ErrDroppedRxPkts { get; set; }
        public double? ErrDroppedRxPktsRate { get; set; }
        public string ErrDroppedTxPkts { get; set; }
        public double? ErrDroppedTxPktsRate { get; set; }
        public string ErrLinkHangs { get; set; }
        public string NicTsStalls { get; set; }
        public string NicTxStalls { get; set; }
        public string NicRxStalls { get; set; }
        public string NicerrDisables { get; set; }
        public string LinkReinits { get; set; }
        public string TotMacMoved { get; set; }
        public double? MacMovedRate { get; set; }
        public string ErrNicMuted { get; set; }
        public string RxcrcErrors { get; set; }
        public double? RxcrcErrorsRate { get; set; }
        public string InterfaceAlias { get; set; }
        public string CurLinkState { get; set; }
        
    }
}