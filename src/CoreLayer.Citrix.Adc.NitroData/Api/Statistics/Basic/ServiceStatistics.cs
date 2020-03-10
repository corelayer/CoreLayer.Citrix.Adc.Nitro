using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic
{
    public class ServiceStatistics
    {
        public string Name { get; set; }
        [JsonPropertyName("svrestablishedconn")]public string ServerEstablishedConnections { get; set; }
        [JsonPropertyName("curclntconnections")]public string CurrentClientConnections { get; set; }
        public string ServiceType { get; set; }
        public string TotalRequests { get; set; }
        public string SurgeCount { get; set; }
        public double? ResponseBytesRate { get; set; }
        public string TotalResponses { get; set; }
        public double? RequestBytesRate { get; set; }
        public string ThroughPut { get; set; }
        public double? ThroughPutRate { get; set; }
        [JsonPropertyName("curtflags")]public string CurrentFlags { get; set; }
        [JsonPropertyName("cursrvrconnections")]public string CurrentServerConnections { get; set; }
        public string PrimaryIpAddress { get; set; }
        public string ActiveTransactions { get; set; }
        [JsonPropertyName("toleratingttlbtransactions")]public string ToleratingTimeToLastByteTransactions { get; set; }
        public double? ResponsesRate { get; set; }
        public string MaxClients { get; set; }
        [JsonPropertyName("avgsvrttfb")]public string AverageServerTimeToFirstByte { get; set; }
        [JsonPropertyName("curload")]public string CurrentLoad { get; set; }
        public string TotalRequestBytes { get; set; }
        [JsonPropertyName("curreusepool")]public string CurrentReusePool { get; set; }
        public string State { get; set; }
        [JsonPropertyName("vsvrservicehits")]public string VirtualServerServiceHits { get; set; }
        [JsonPropertyName("totsvrttlbtransactions")]public string TotalServerTimeToLastByteTransactions { get; set; }
        [JsonPropertyName("frustratingttlbtransactions")]public string FrustratingTImeToLastByteTransactions { get; set; }
        public string TotalResponseBytes { get; set; }
        public int? PrimaryPort { get; set; }
        public double? RequestsRate { get; set; }
        [JsonPropertyName("vsvrservicehitsrate")]public double? VirtualServerServiceHitsRate { get; set; }
        public string TotalConnReassemblyQueue75 { get; set; }
        public string TotalConnReassemblyQueueFlush { get; set; }
        [JsonPropertyName("httpmaxhdrszpkts")]public string HttpMaxHeaderSizePackets { get; set; }
        [JsonPropertyName("tcpmaxooopkts")]public string TcpMaxOooPackets { get; set; }
    }
}