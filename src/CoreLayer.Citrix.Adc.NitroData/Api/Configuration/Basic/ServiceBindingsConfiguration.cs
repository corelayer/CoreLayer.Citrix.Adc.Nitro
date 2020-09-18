using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServiceBindingsConfiguration
    {
        public string ServiceName { get; set; }
        public string IpAddress { get; set; }
        public int? Port { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        [JsonPropertyName("vservername")]public string VirtualServerName { get; set; }
        
    }
}