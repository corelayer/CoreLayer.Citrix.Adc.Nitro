using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/lbvserver";
        public override INitroRequestOptions Options => new LbvserverUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public LbvserverUpdateRequestConfiguration(LbvserverUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}