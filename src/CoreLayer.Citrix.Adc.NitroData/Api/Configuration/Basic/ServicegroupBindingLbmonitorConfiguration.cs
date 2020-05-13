using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupBindingLbmonitorConfiguration
    {
        //todo check  documented types == actual returned types
        public string ServicegroupName { get; set; }
        public int? Port { get; set; }
        public string NameServer { get; set; }
        public string State { get; set; }
        public double? HashId { get; set; }
        public double? ServerId { get; set; }
        public string CustomServerId { get; set; }
        public double? Weight { get; set; }
        [JsonPropertyName("monitor_name")]public string MonitorName { get; set; }
        public double? DbsTtl { get; set; }
        public bool? Passive { get; set; }
        public string MonState { get; set; }
        public double? MonWeight { get; set; }
    }
}