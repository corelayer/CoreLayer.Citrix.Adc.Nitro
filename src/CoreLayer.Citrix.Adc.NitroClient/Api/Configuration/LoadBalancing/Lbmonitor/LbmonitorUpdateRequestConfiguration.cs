using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/lbmonitor";
        public override INitroRequestOptions Options => new LbmonitorUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public LbmonitorUpdateRequestConfiguration(LbmonitorUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}