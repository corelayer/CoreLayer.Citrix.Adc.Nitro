using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/cspolicylabel_binding";
        public override INitroRequestDataRoot DataRoot => new CsPolicyLabelBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyLabelBindingGetRequestOptions();
    }
}