using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Rewrite.RewritePolicyLabel
{
    public class RewritePolicyLabelStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/rewritepolicylabel";
        public override INitroRequestOptions Options { get; set; } = new RewritePolicyLabelStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new RewritePolicyLabelStatRequestDataRoot();
                
        public RewritePolicyLabelStatRequestConfiguration() {}
    }
}