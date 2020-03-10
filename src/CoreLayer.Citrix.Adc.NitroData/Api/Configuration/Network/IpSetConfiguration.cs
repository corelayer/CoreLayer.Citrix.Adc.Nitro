using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network
{
    public class IpSetConfiguration : IIpsetConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}