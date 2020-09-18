using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsPolicyLabelBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/cspolicy_cspolicylabel_binding";
        public override INitroRequestDataRoot DataRoot => new CsPolicyCsPolicyLabelBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyCsPolicyLabelBindingGetRequestOptions();
    }
}