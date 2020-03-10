using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddServicegroupMemberRequestData : INitroRequestData
    {
        public string ServicegroupName { get; }
        public string Ip { get; set; }
        public string ServerName { get; set; }
        public int? Port { get; set; }
        public double? Weight { get; set; }
        public string CustomServerId { get; set; }
        public double? ServerId { get; set; }
        public string State { get; set; }
        public double? HashId { get; set; }

        public ServicegroupBindingAddServicegroupMemberRequestData(string servicegroupName)
        {
            ServicegroupName = servicegroupName;
        }
    }
}