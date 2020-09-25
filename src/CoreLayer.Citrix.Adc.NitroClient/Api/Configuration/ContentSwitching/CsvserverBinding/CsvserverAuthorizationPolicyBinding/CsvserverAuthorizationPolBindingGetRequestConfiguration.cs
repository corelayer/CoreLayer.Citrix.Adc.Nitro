using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/csvserver_authorizationpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAuthorizationPolicyBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAuthorizationPolicyBindingGetRequestOptions();
    }
}