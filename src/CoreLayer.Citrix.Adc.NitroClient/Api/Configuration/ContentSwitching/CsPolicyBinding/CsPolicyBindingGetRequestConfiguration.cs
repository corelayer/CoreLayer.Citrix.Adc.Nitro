using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/cspolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsPolicyBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyBindingGetRequestOptions();
    }
}