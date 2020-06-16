using System.Dynamic;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsStats
    {
        [JsonPropertyName("rescpuusagepcnt")]public double? AverageCpuUsagePercent { get; set; }
        [JsonPropertyName("cpuusagepcnt")]public double? CpuUsagePercent { get; set; }
        public string CacheMaxMemoryKb { get; set; }
        [JsonPropertyName("delcmpratio")]public double? DelCompressionRatio { get; set; }
        [JsonPropertyName("rescpuusage")]public string AverageCpuUsage { get; set; }
        public string CpuUsage { get; set; }
        [JsonPropertyName("resmemusage")]public string MemUsagePercent { get; set; }
        [JsonPropertyName("comptotaldatacompressionratio")]public double? CompressionTotalDataCompressionRatio { get; set; }
        [JsonPropertyName("compratio")]public double? CompressionRatio { get; set; }
        public string CacheUtilizedMemoryKb { get; set; }
        public string CacheMaxMemoryActiveKb { get; set; }
        public string Cache64MaxMemoryKb { get; set; }
        public string CachePercentOriginBandwidthSaved { get; set; }
        public string CacheTotMisses { get; set; }
        public double? CacheMissesRate { get; set; }
        public string CacheTotHits { get; set; }
        public double? CacheHitsRate { get; set; }
        public string SslNumCardsUp { get; set; }
        public double? MemUsagePcnt { get; set; }
        public string MemUseInMb { get; set; }
        [JsonPropertyName("mgmtcpuusagepcnt")]public double? ManagementCpuUsagePercent { get; set; }
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
        [JsonPropertyName("totrxmbits")]public string TotReceiveMbits { get; set; }
        [JsonPropertyName("rxmbitsrate")]public double? ReceiveMbitsRate { get; set; }
        [JsonPropertyName("tottxmbits")]public string TotTransmitMbits { get; set; }
        [JsonPropertyName("txmbitsrate")]public double? TransmitMbitsRate { get; set; }
        public string TcpCurClientConn { get; set; }
        public string TcpCurClientConnEstablished { get; set; }
        public string TcpCurServerConn { get; set; }
        public string TcpCurServerConnEstablished { get; set; }
        public string HttpTotRequests { get; set; }
        public double? HttpRequestsRate { get; set; }
        public string HttpTotResponses { get; set; }
        public double? HttpResponsesRate { get; set; }
        [JsonPropertyName("httptotrxresponsebytes")]public string HttpTotReceivedResponseBytes { get; set; }
        [JsonPropertyName("httprxrequestbytesrate")]public double? HttpReceivedRequestBytesRate { get; set; }
        [JsonPropertyName("httptotrxrequestbytes")]public string HttpTotReceivedRequestBytes { get; set; } 
        [JsonPropertyName("httprxresponsebytesrate")]public double? HttpReceivedResponseBytesRate { get; set; }
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
        public double? MiscCounter1 { get; set; }
        public string NumCpus { get; set; }
        
    }
}