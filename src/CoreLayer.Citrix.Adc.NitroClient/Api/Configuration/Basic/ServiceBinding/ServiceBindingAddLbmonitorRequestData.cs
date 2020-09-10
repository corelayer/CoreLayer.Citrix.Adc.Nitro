using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddLbmonitorRequestData : INitroRequestData
    {
        public string Name { get; }
        [JsonPropertyName("monitor_name")]public string MonitorName { get; set; }
        [JsonPropertyName("monstate")]public string MonitorState { get; set; }
        public double? Weight { get; set; }
        public bool? Passive { get; set; }

        public ServiceBindingAddLbmonitorRequestData(string serviceName)
        {
            Name = serviceName;
        }
    }
}