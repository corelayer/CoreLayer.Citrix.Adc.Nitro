using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingRemoveDosPolicyRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/service_dospolicy_binding";
        public override INitroRequestDataRoot DataRoot => new ServiceBindingRemoveDosPolicyRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServiceBindingRemoveDosPolicyRequestOptions();
    }
}