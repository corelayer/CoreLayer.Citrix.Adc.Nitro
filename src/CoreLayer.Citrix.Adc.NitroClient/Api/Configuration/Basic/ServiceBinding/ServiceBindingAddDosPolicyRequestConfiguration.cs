using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddDosPolicyRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/service_dospolicy_binding";
        public override INitroRequestOptions Options => new ServiceBindingAddDosPolicyRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServiceBindingAddDosPolicyRequestConfiguration(ServiceBindingAddDosPolicyRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}