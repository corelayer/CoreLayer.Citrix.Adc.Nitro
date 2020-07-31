using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.DnsPolicyLabel
{
    public class DnsPolicyLabelStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/dnspolicylabel";
        public override INitroRequestOptions Options { get; set; } = new DnsPolicyLabelStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new DnsPolicyLabelStatRequestDataRoot();
                        
        public DnsPolicyLabelStatRequestConfiguration() {}
    }
}