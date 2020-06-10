namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ha
{
    public class HaNodeStats
    {
        public string HaCurStatus { get; set; }
        public string HaCurState { get; set; }
        public string HaCurMasterState { get; set; }
        public string TransTime { get; set; }
        public string HaTotPktRx { get; set; }
        public double? HaPktRxRate { get; set; }
        public string HaTotPktTx { get; set; }
        public double? HaPktTxRate { get; set; }
        public string HaErrSyncFailure { get; set; }
        public string HaErrPropTimeout { get; set; }
    }
}