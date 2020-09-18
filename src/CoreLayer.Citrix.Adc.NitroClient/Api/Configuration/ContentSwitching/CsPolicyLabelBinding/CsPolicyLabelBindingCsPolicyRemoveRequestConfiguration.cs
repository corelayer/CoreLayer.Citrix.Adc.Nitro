using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/cspolicylabel_cspolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsPolicyLabelBindingCsPolicyRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyLabelBindingCsPolicyRemoveRequestOptions();
    }
}