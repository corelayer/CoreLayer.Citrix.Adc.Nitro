using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddLbmonitorRequestData  : INitroRequestData
    {
        //TODO add undocumented required params
        public string ServicegroupName { get; }
        public int? Port { get; set; }
        [JsonPropertyName("monitor_name")]public string MonitorName { get; set; }
        [JsonPropertyName("monstate")]public string MonitorState { get; set; }
        public bool? Passive { get; set; }
        public double? Weight { get; set; }
        public string CustomServerId { get; set; }
        public double? ServerId { get; set; }
        public string State { get; set; }
        public double? HashId { get; set; }

        public ServicegroupBindingAddLbmonitorRequestData(string servicegroupName)
        {
            ServicegroupName = servicegroupName;
        }
    }
}