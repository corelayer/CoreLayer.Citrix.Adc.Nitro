using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddScPolicyRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/service_scpolicy_binding";
        public override INitroRequestOptions Options => new ServiceBindingAddScPolicyRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServiceBindingAddScPolicyRequestConfiguration(ServiceBindingAddScPolicyRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}