namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network
{
    public class VlanStats
    {
        public string Id { get; set; }
        public string VlanTotRxPkts { get; set; }
        public double? VlanRxPktsRate { get; set; }
        public string VlanTotRxBytes { get; set; }
        public double? VlanRxBytesRate { get; set; }
        public string VlanTotTxPkts { get; set; }
        public double? VlanTxPktsRate { get; set; }
        public string VlanTotTxBytes { get; set; }
        public double? VlanTxBytesRate { get; set; }
        public string VlanTotDroppedPkts { get; set; }
        public string VlanTotBroadcastPkts { get; set; }
        
    }
}