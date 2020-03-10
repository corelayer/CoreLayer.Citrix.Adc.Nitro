using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/lbmonitor";
        public override INitroRequestOptions Options => new LbmonitorAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public LbmonitorAddRequestConfiguration(LbmonitorAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}