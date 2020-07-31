using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb
{
    public class GslbVserverStats
    {
        public string Name { get; set; }
        [JsonPropertyName("establishedconn")]public string EstablishedConnections { get; set; }
        [JsonPropertyName("inactsvcs")]public string InactiveServices { get; set; }
        [JsonPropertyName("vslbhealth")]public string VirtualServerLoadBalancingHealth { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        [JsonPropertyName("actsvcs")]public string ActiveServices { get; set; }
        [JsonPropertyName("tothits")]public string TotalHits { get; set; }
        [JsonPropertyName("hitsrate")]public double? HitsRate { get; set; }
        [JsonPropertyName("vsvrtotbkplbhits")]public string VirtualServerTotalBackupLoadBalancingMethodHits { get; set; }
        [JsonPropertyName("vsvrtotbkplbfail")]public string VirtualServerTotalBackupLoadBalancingMethodFail { get; set; }
        [JsonPropertyName("curpersistencesessions")]public string CurrentPersistenceSessions { get; set; }
        [JsonPropertyName("vsvrtotpersistencehits")]public string VirtualServerTotalPersistenceHits { get; set; }
        public string TotalRequestBytes { get; set; }
        public double? RequestBytesRate { get; set; }
        public string TotalResponseBytes { get; set; }
        public double? ResponseBytesRate { get; set; }
        [JsonPropertyName("sothreshold")]public string SpillOverThreshold { get; set; }
        [JsonPropertyName("totspillovers")]public string TotalSpillOvers { get; set; }
        [JsonPropertyName("totvserverdownbackuphits")]public string TotalVirtualServerDownBackupHits { get; set; }
        [JsonPropertyName("totalrequests")]public string TotalRequests { get; set; }
        [JsonPropertyName("requestsrate")]public double? RequestsRate { get; set; }
        [JsonPropertyName("totalresponses")]public string TotalResponses { get; set; }
        [JsonPropertyName("responsesrate")]public double? ResponsesRate { get; set; }
        [JsonPropertyName("curclntconnections")]public string CurrentClientConnections { get; set; }
        [JsonPropertyName("cursrvrconnections")]public string CurrentServerConnections { get; set; }
    }
    
}