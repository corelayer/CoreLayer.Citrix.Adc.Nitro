using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddScPolicyRequestDataRoot : INitroRequestDataRoot
    {
        public ServiceBindingAddScPolicyRequestDataRoot(dynamic data)
        {
            Service_ScPolicy_binding = new dynamic[]{data};
        }

        public ServiceBindingAddScPolicyRequestDataRoot(dynamic[] data)
        {
            Service_ScPolicy_binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Service_ScPolicy_binding { get; set; }
    }
}