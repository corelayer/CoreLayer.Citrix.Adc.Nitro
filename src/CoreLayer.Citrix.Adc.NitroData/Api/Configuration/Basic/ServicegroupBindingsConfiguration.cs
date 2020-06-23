using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupBindingsConfiguration
    {
        public string ServicegroupName { get; set; }
        public string IpAddress { get; set; }
        public int? Port { get; set; }
        public string State { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        [JsonPropertyName("vservername")]public string VirtualServerName { get; set; }
    }
}