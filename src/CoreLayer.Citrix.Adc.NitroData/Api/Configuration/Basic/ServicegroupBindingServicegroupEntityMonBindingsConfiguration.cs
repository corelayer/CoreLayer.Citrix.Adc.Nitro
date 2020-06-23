using System.Dynamic;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupBindingServicegroupEntityMonBindingsConfiguration
    {
        //todo check  documented types == actual returned types
        public string ServicegroupName { get; set; }
        public string ServicegroupName2 { get; set; }
        public int? Port { get; set; }
        public string NameServer { get; set; }
        public string State { get; set; }
        public double? HashId { get; set; }
        public double? ServerId { get; set; }
        public string CustomServerId { get; set; }
        public double? Weight { get; set; }
        [JsonPropertyName("monitor_name")]public string MonitorName { get; set; }
        [JsonPropertyName("dbsttl")]public double? DomainBasedServiceTtl { get; set; }
        public bool? Passive { get; set; }
        public double? ResponseTime { get; set; }
        public string LastResponse { get; set; }
        [JsonPropertyName("monitor_state")]public string MonitorState { get; set; }
        public double? MonitorTotalProbes { get; set; }
        public double? MonitorTotalFailedProbes { get; set; }
        public double? MonitorCurrentFailedProbes { get; set; }
    }
}