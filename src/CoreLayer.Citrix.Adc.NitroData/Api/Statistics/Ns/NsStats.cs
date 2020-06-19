using System.Dynamic;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsStats
    {
        [JsonPropertyName("rescpuusagepcnt")]public double? AverageCpuUsagePercent { get; set; }
        [JsonPropertyName("cpuusagepcnt")]public double? CpuUsagePercent { get; set; }
        public string CacheMaxMemoryKb { get; set; }
        [JsonPropertyName("delcmpratio")]public double? CompressionRatio { get; set; }
        [JsonPropertyName("rescpuusage")]public string AverageCpuUsage { get; set; }
        public string CpuUsage { get; set; }
        [JsonPropertyName("resmemusage")]public string MemUsagePercent { get; set; }
        [JsonPropertyName("comptotaldatacompressionratio")]public double? CompressionTotalDataCompressionRatio { get; set; }
        [JsonPropertyName("compratio")]public double? CompressionRatioServerToClient { get; set; }
        public string CacheUtilizedMemoryKb { get; set; }
        public string CacheMaxMemoryActiveKb { get; set; }
        public string Cache64MaxMemoryKb { get; set; }
        public string CachePercentOriginBandwidthSaved { get; set; }
        [JsonPropertyName("cachetotmisses")]public string CacheTotalMisses { get; set; }
        public double? CacheMissesRate { get; set; }
        [JsonPropertyName("cachetothits")]public string CacheTotalHits { get; set; }
        public double? CacheHitsRate { get; set; }
        [JsonPropertyName("sslnumcardsup")]public string SslNumberOfCardsUp { get; set; }
        [JsonPropertyName("memusagepcnt")]public double? MemoryUsagePercent { get; set; }
        [JsonPropertyName("memuseinmb")]public string MemoryUseInMb { get; set; }
        [JsonPropertyName("mgmtcpuusagepcnt")]public double? ManagementCpuUsagePercent { get; set; }
        [JsonPropertyName("pktcpuusagepcnt")]public double? PacketEngineCpuUsagePercent { get; set; }
        public string StartTimeLocal { get; set; }
        public string StartTime { get; set; }
        [JsonPropertyName("transtime")]public string TransitionTime { get; set; }
        [JsonPropertyName("hacurstate")]public string HighAvailabilityCurrentState { get; set; }
        [JsonPropertyName("hacurmasterstate")]public string HighAvailabilityCurrentMasterState { get; set; }
        public string SslCards { get; set; }
        [JsonPropertyName("disk0perusage")]public double? Disk0PercentUsage { get; set; }
        [JsonPropertyName("disk1perusage")]public double? Disk1PercentUsage { get; set; }
        [JsonPropertyName("disk0avail")]public double? Disk0Available { get; set; }
        [JsonPropertyName("disk1avail")]public double? Disk1Available { get; set; }
        [JsonPropertyName("totrxmbits")]public string TotalReceiveMbits { get; set; }
        [JsonPropertyName("rxmbitsrate")]public double? ReceiveMbitsRate { get; set; }
        [JsonPropertyName("tottxmbits")]public string TotalTransmitMbits { get; set; }
        [JsonPropertyName("txmbitsrate")]public double? TransmitMbitsRate { get; set; }
        [JsonPropertyName("tcpcurclientconn")]public string TcpCurrentClientConnections { get; set; }
        [JsonPropertyName("tcpcurclientconnestablished")]public string TcpCurrentClientConnectionsEstablished { get; set; }
        [JsonPropertyName("tcpcurserverconn")]public string TcpCurrentServerConnections { get; set; }
        [JsonPropertyName("tcpcurserverconnestablished")]public string TcpCurrentServerConnectionsEstablished { get; set; }
        [JsonPropertyName("httptotrequests")]public string HttpTotalRequests { get; set; }
        public double? HttpRequestsRate { get; set; }
        [JsonPropertyName("httptotresponses")]public string HttpTotalResponses { get; set; }
        public double? HttpResponsesRate { get; set; }
        [JsonPropertyName("httptotrxresponsebytes")]public string HttpTotalReceivedResponseBytes { get; set; }
        [JsonPropertyName("httprxrequestbytesrate")]public double? HttpReceivedRequestBytesRate { get; set; }
        [JsonPropertyName("httptotrxrequestbytes")]public string HttpTotalReceivedRequestBytes { get; set; } 
        [JsonPropertyName("httprxresponsebytesrate")]public double? HttpReceivedResponseBytesRate { get; set; }
        [JsonPropertyName("ssltottransactions")]public string SslTotalTransactions { get; set; }
        public double? SslTransactionsRate { get; set; }
        [JsonPropertyName("ssltotsessionhits")]public string SslTotalSessionHits { get; set; }
        public double? SslSessionHitsRate { get; set; }
        public string AppFirewallRequests { get; set; }
        public double? AppFirewallRequestsRate { get; set; }
        public string AppFirewallResponses { get; set; }
        public double? AppFirewallResponsesRate { get; set; }
        public string AppFirewallAborts { get; set; }
        public double? AppFirewallAbortsRate { get; set; }
        public string AppFirewallRedirects { get; set; }
        public double? AppFirewallRedirectsRate { get; set; }
        [JsonPropertyName("misccounter0")]public double? MiscellaneousCounter0 { get; set; }
        [JsonPropertyName("misccounter1")]public double? MiscellaneousCounter1 { get; set; }
        [JsonPropertyName("numcpus")]public string NumberOfCpus { get; set; }
        
    }
}