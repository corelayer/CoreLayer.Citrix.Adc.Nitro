using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddLbmonitorRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/service_lbmonitor_binding";
        public override INitroRequestOptions Options => new ServiceBindingAddLbmonitorRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServiceBindingAddLbmonitorRequestConfiguration(ServiceBindingAddLbmonitorRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}