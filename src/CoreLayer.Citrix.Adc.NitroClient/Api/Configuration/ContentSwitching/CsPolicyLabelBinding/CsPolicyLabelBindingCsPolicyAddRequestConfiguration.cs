using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/cspolicylabel_cspolicy_binding";
        public override INitroRequestOptions Options => new CsPolicyLabelBindingCsPolicyAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsPolicyLabelBindingCsPolicyAddRequestConfiguration(CsPolicyLabelBindingCsPolicyAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}