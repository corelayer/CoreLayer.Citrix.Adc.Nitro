using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddScPolicyRequestData : INitroRequestData
    {
        public string PolicyName { get; set; }
        public string Name { get; set; }
    }
}