using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing
{
    public class LbvserverServiceBindingConfiguration
    {
        public string ServiceName { get; set; }
        public string ServicegroupName { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string CookieIpPort { get; set; }
        public int? Port { get; set; }
        [JsonPropertyName("vsvrbindsvcport")]public int? VirtualServerBindServicePort { get; set; }
        [JsonPropertyName("curstate")]public string CurrentState { get; set; }
        public string PreferredLocation { get; set; }
        [JsonPropertyName("vserverip")]public string VirtualServerIp { get; set; }
        [JsonPropertyName("ipv46")]public string IpVersion4Or6 { get; set; }
        public string DynamicWeight { get; set; }
        [JsonPropertyName("vsvrbindsvcip")]public string VirtualServerBindServiceIp { get; set; }
        public string ServiceType { get; set; }
    }
}