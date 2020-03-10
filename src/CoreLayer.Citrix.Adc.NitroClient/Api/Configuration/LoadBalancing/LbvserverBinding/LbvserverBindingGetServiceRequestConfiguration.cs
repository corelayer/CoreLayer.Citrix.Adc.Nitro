using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetServiceRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/lbvserver_service_binding";
        public override INitroRequestDataRoot DataRoot => new LbvserverBindingGetServiceRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LbvserverBindingGetServiceRequestOptions();
    }
}