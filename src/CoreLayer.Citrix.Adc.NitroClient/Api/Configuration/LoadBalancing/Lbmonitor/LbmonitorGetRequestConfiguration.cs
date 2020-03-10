using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/lbmonitor";
        public override INitroRequestDataRoot DataRoot => new LbmonitorGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LbmonitorGetRequestOptions();
    }
}