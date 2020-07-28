using System.Dynamic;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb
{
    public class GslbServiceStats
    {
        public string ServiceName { get; set; }
        [JsonPropertyName("servicetype")]public string ServiceType { get; set; }
        [JsonPropertyName("state")]public string State { get; set; }
        [JsonPropertyName("curload")]public string CurrentLoad { get; set; }
        [JsonPropertyName("primaryport")]public int? PrimaryPort { get; set; }
        [JsonPropertyName("primaryipaddress")]public string PrimaryIpAddress { get; set; }
        [JsonPropertyName("curclntconnections")]public string CurrentClientConnections { get; set; }
        [JsonPropertyName("cursrvrconnections")]public string CurrentServerConnections { get; set; }
        [JsonPropertyName("establishedconn")]public string EstablishedConnections { get; set; }
        [JsonPropertyName("totalrequests")]public string TotalRequests { get; set; }
        [JsonPropertyName("requestsrate")]public double? RequestsRate { get; set; }
        [JsonPropertyName("totalresponses")]public string TotalResponses { get; set; }
        [JsonPropertyName("responsesRate")]public double? ResponsesRate { get; set; }
        [JsonPropertyName("totalrequestbytes")]public string TotalRequestBytes { get; set; }
        [JsonPropertyName("requestbytesrate")]public double? RequestBytesRate { get; set; }
        [JsonPropertyName("totalresponsebytes")]public string TotalResponseBytes { get; set; }
        [JsonPropertyName("reponsebytesrate")]public double? ResponseBytesRate { get; set; }
        [JsonPropertyName("vsvrservicehits")]public string VirtualServerServiceHits { get; set; }
        [JsonPropertyName("vsvrservicehitsrate")]public double? VirtualServerServiceHitsRate { get; set; }
    }
}