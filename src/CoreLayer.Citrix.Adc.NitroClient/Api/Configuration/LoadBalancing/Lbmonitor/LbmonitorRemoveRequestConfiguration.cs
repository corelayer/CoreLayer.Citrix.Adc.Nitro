using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/lbmonitor";
        public override INitroRequestDataRoot DataRoot => new LbmonitorRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LbmonitorRemoveRequestOptions();
    }
}