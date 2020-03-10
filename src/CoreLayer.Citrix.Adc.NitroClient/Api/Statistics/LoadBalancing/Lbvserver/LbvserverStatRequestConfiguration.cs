using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.LoadBalancing.Lbvserver
{
    public class LbvserverStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/lbvserver";
        public override INitroRequestOptions Options { get; set; } = new LbvserverStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new LbvserverStatRequestDataRoot();
        
        public LbvserverStatRequestConfiguration() {}
    }
}