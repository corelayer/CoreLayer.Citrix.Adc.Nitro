using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddLbmonitorRequestData : INitroRequestData
    {
        public string Name { get; }
        public string Monitor_Name { get; set; }
        public string MonState { get; set; }
        public double? Weight { get; set; }
        public bool? Passive { get; set; }

        public ServiceBindingAddLbmonitorRequestData(string serviceName)
        {
            Name = serviceName;
        }
    }
}