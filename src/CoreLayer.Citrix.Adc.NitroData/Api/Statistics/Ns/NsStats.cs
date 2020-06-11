using System.Dynamic;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsStats
    {
        public double? ResCpuUsagePcnt { get; set; }
        public double? CpuUsagePcnt { get; set; }
        public string CacheMaxMemoryKb { get; set; }
        public double? DelCmpRatio { get; set; }
        public string ResCpuUsage { get; set; }
        public string CpuUsage { get; set; }
        public string ResMemUsage { get; set; }
        public double? CompTotalDataCompressionRatio { get; set; }
        public double? CompRatio { get; set; }
        public string CacheUtilizedMemoryKb { get; set; }
        public string CacheMaxMemoryActiveKb { get; set; }
        public string Cache64MaxMemoryKb { get; set; }
        public string CachePercentOriginBandwidthSaved { get; set; }
        public string CacheTotMisses { get; set; }
        public double? CacheMissesRate { get; set; }
        public string CacheTotHits { get; set; }
        public double? CacheHitsRate { get; set; }
        public string SslNumCardSup { get; set; }
        public double? MemUsagePcnt { get; set; }
        public string MemUseInMb { get; set; }
        public double? MgmtCpuUsagePcnt { get; set; }
        public double? PktCpuUsagePcnt { get; set; }
        public string StartTimeLocal { get; set; }
        public string StartTime { get; set; }
        public string TransTime { get; set; }
        public string HaCurState { get; set; }
        public string HaCurMasterState { get; set; }
        public string SslCards { get; set; }
        public double? Disk0PerUsage { get; set; }
        public double? Disk1PerUsage { get; set; }
        public double? Disk0Avail { get; set; }
        public double? Disk1Avail { get; set; }
        public string TotRxMbits { get; set; }
        public double? RxMbitsRate { get; set; }
        public string TotTxMbits { get; set; }
        public double? TxMbitsRate { get; set; }
        public string TcpCurClientConn { get; set; }
        public string TcpCurClientConnEstablished { get; set; }
        public string TcpCurServerConn { get; set; }
        public string TcpCurServerConnEstablished { get; set; }
        public string HttpTotRequests { get; set; }
        public double? HttpRequestsRate { get; set; }
        public string HttpTotResponses { get; set; }
        public double? HttpResponsesRate { get; set; }
        public string HttpTotRxResponseBytes { get; set; }
        public double? HttpRxRequestBytesRate { get; set; }
        public string HttpTotRxRequestBytes { get; set; } 
        public double? HttpRxResponseBytesRate { get; set; }
        public string SslTotTransactions { get; set; }
        public double? SslTransactionsRate { get; set; }
        public string SslTotSessionHits { get; set; }
        public double? SslSessionHitsRate { get; set; }
        public string AppFirewallRequests { get; set; }
        public double? AppFirewallRequestsRate { get; set; }
        public string AppFirewallResponses { get; set; }
        public double? AppFirewallResponsesRate { get; set; }
        public string AppFirewallAborts { get; set; }
        public double? AppFirewallAbortsRate { get; set; }
        public string AppFirewallRedirects { get; set; }
        public double? AppFirewallRedirectsRate { get; set; }
        public double? MiscCounter0 { get; set; }
        public double? MisCounter1 { get; set; }
        public string NumCpus { get; set; }
        
    }
}