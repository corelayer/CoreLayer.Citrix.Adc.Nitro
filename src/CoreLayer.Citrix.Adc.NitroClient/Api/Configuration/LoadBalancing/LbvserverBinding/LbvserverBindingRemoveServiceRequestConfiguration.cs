using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingRemoveServiceRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/lbvserver_service_binding";
        public override INitroRequestDataRoot DataRoot => new LbvserverRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LbvserverRemoveRequestOptions();
    }
}