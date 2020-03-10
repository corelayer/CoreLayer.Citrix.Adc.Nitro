using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddLbmonitorRequestData  : INitroRequestData
    {
        public string ServicegroupName { get; }
        public int? Port { get; set; }
        public string Monitor_Name { get; set; }
        public string MonState { get; set; }
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