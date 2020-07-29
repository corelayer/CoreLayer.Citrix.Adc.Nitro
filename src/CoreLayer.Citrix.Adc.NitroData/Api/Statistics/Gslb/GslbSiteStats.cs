using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb
{
    public class GslbSiteStats
    {
        public string SiteName { get; set; }
        public string SitePublicIp { get; set; }
        public string SiteIp { get; set; }
        public string SiteType { get; set; }
        [JsonPropertyName("sitemepstatus")]public string SiteMetricExchangePolicyStatus { get; set; }
        [JsonPropertyName("persexchange")]public string PersistentEntriesExchange { get; set; }
        [JsonPropertyName("nwmetricexchange")]public string NetworkMetricExchange { get; set; }
        [JsonPropertyName("sitemetricexchange")]public string SiteMetricExchange { get; set; }
        [JsonPropertyName("siteipstr")]public string SiteIpString { get; set; }
        [JsonPropertyName("sitepublicipstr")]public string SitePublicIpString { get; set; }
        [JsonPropertyName("sitemetricmepstatus")]public string SiteMetricMetricExchangePolicyStatus { get; set; }
        [JsonPropertyName("nwmetricmepstatus")]public string NetworkMetricMetricExchangePolicyStatus { get; set; }
        public string SiteTotalResponses { get; set; }
        public double? SiteResponsesRate { get; set; }
        public string SiteTotalRequests { get; set; }
        public double? SiteRequestsRate { get; set; }
        public string SiteTotalResponseBytes { get; set; }
        public double? SiteResponseBytesRate { get; set; }
        public string SiteTotalRequestBytes { get; set; }
        public double? SiteRequestBytesRate { get; set; }
        [JsonPropertyName("sitecurclntconnections")]public string SiteCurrentClientConnections { get; set; }
        [JsonPropertyName("sitecursrvrconnections")]public string SiteCurrentServerConnections { get; set; }
    }
}