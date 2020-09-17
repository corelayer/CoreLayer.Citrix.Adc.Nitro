using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCrvServerBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/cspolicy_crvserver_binding";
        public override INitroRequestDataRoot DataRoot => new CsPolicyCrvServerBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyCrvServerBindingGetRequestOptions();
    }
}