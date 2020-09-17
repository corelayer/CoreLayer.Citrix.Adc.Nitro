using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/cspolicylabel_cspolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsPolicyLabelBindingCsPolicyGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyLabelBindingCsPolicyGetRequestOptions();
    }
}