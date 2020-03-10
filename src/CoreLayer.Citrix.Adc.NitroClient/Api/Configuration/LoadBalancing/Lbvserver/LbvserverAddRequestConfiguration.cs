using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/lbvserver";
        public override INitroRequestOptions Options => new LbvserverAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get;  }
        
        public LbvserverAddRequestConfiguration(LbvserverAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}