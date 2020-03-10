using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network
{
    public class NetProfileConfiguration : INetProfileConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        [JsonPropertyName("srcip")]public string SourceIp { get; set; }
        [JsonPropertyName("srcippersistency")]public string SourceIpPersistency { get; set; }
        public string OverrideLsn { get; set; }
        public string NatRule { get; set; }
        public string NetMask { get; set; }
        public string RewriteIp { get; set; }
        public string Mbf { get; set; }
        public string ProxyProtocol { get; set; }
        public string ProxyProtocolTxVersion { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}