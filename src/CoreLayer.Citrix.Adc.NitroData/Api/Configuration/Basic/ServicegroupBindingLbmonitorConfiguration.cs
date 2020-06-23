using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupBindingLbmonitorConfiguration
    {
        public string ServicegroupName { get; set; }
        public int? Port { get; set; }
        public string NameServer { get; set; }
        public string State { get; set; }
        public double? HashId { get; set; }
        public double? ServerId { get; set; }
        public string CustomServerId { get; set; }
        public string Weight { get; set; }
        [JsonPropertyName("monitor_name")]public string MonitorName { get; set; }
        [JsonPropertyName("dbsttl")]public double? DomainBasedServiceTtl { get; set; }
        public bool? Passive { get; set; }
        [JsonPropertyName("monstate")]public string MonitorState { get; set; }
        [JsonPropertyName("monweight")]public string MonitorWeight { get; set; }
    }
}