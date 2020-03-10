using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingRemoveLbmonitorRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/service_lbmonitor_binding";
        public override INitroRequestDataRoot DataRoot => new ServiceBindingRemoveLbmonitorRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServiceBindingRemoveLbmonitorRequestOptions();
    }
}