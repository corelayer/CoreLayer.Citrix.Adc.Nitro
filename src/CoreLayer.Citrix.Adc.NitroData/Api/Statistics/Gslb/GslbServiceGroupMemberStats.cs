using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb
{
    public class GslbServiceGroupMemberStats
    {
        public string ServiceGroupName { get; set; }
        public string ServiceType { get; set; }
        public string State { get; set; }
        public string PrimaryIpAddress { get; set; }
        public int? PrimaryPort { get; set; }
        [JsonPropertyName("curload")]public string CurrentLoad { get; set; }
        [JsonPropertyName("curclntconnections")]public string CurrentClientConnections { get; set; }
        [JsonPropertyName("cursrvrconnections")]public string CurrentServerConnections { get; set; }
        [JsonPropertyName("totalrequests")]public string TotalRequests { get; set; }
        [JsonPropertyName("requestsrate")]public double? RequestsRate { get; set; }
        [JsonPropertyName("totalresponses")]public string TotalResponses { get; set; }
        [JsonPropertyName("responsesrate")]public double? ResponsesRate { get; set; }
        [JsonPropertyName("totalrequestbytes")]public string TotalRequestBytes { get; set; }
        [JsonPropertyName("requestbytesrate")]public double? RequestBytesRate { get; set; }
        [JsonPropertyName("totaltresponsebytes")]public string TotalResponseBytes { get; set; }
        [JsonPropertyName("responsebytesrate")]public double? ResponseBytesRate { get; set; }
        [JsonPropertyName("establishedconn")]public string EstablishedConnections { get; set; }
    }
}