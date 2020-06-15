using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Rewrite.RewritePolicy
{
    public class RewritePolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/rewritepolicy";
        public override INitroRequestOptions Options { get; set; } = new RewritePolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new RewritePolicyStatRequestDataRoot();
        
        public RewritePolicyStatRequestConfiguration() {}
    }
}