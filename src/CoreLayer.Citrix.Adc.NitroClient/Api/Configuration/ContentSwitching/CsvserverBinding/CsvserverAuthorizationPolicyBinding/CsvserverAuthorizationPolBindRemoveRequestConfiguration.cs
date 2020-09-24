using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_authorizationpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAuthorizationPolicyBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAuthorizationPolicyBindingRemoveRequestOptions();
    }
}