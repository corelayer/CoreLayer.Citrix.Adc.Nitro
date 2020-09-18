using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsVServerBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/cspolicy_csvserver_binding";
        public override INitroRequestDataRoot DataRoot => new CsPolicyCsVServerBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyCsVServerBindingGetRequestOptions();
    }
}