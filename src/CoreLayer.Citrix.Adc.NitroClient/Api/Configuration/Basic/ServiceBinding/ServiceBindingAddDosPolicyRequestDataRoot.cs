using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddDosPolicyRequestDataRoot : INitroRequestDataRoot
    {
        public ServiceBindingAddDosPolicyRequestDataRoot(dynamic data)
        {
            Service_DosPolicy_binding = new dynamic[]{data};
        }

        public ServiceBindingAddDosPolicyRequestDataRoot(dynamic[] data)
        {
            Service_DosPolicy_binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Service_DosPolicy_binding { get; set; }
        
    }
}