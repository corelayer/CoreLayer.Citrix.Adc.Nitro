using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/lbvserver";
        public override INitroRequestDataRoot DataRoot => new LbvserverRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LbvserverRemoveRequestOptions();
    }
}