using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServiceBindingLbmonitorConfiguration
    {
        public string Weight { get; set; }
        public string Name { get; set; }
        public string Passive { get; set; }
        [JsonPropertyName("monitor_name")]public string MonitorName { get; set; }
        [JsonPropertyName("monstate")]public string MonitorConfiguredState { get; set; }
        [JsonPropertyName("monstatcode")]public string MonitorStatCode { get; set; }
        [JsonPropertyName("dup_weight")]public string DuplicateWeight { get; set; }
        public string ResponseTime { get; set; }
        public string TotalFailedProbes { get; set; }
        [JsonPropertyName("monstatparam2")]public int? MonitorStatParameter2 { get; set; }
        public string LastResponse { get; set; }
        public string FailedProbes { get; set; }
        [JsonPropertyName("monstatparam3")]public int? MonitorStatParameter3 { get; set; }
        public string TotalProbes { get; set; }
        [JsonPropertyName("monitor_state")]public string MonitorRunningState { get; set; }
        [JsonPropertyName("dup_state")]public string DuplicateState { get; set; }
        public string MonitorTotalProbes { get; set; }
        [JsonPropertyName("monstatparam1")]public int? MonitorStatParameter1 { get; set; }
        public string MonitorTotalFailedProbes { get; set; }
        public string MonitorCurrentFailedProbes { get; set; }
    }
}