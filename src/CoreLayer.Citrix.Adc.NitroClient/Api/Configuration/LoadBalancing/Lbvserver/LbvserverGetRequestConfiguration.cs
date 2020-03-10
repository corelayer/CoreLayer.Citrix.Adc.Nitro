using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/lbvserver";
        public override INitroRequestOptions Options { get; set; } = new LbvserverGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new LbvserverGetRequestDataRoot();
    }
}