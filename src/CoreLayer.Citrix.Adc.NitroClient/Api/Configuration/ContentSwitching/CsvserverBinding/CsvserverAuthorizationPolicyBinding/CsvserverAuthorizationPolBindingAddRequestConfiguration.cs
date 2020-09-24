using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_authorizationpolicy_binding";
        public override INitroRequestOptions Options => new CsvserverAuthorizationPolicyBindingAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverAuthorizationPolicyBindingAddRequestConfiguration(CsvserverAuthorizationPolicyBindingAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}