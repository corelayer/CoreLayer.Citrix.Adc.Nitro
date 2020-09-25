using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_authorizationpolicy_binding")]
        public CsvserverAuthorizationPolicyBindingConfiguration[] CsvserverAuthorizationPolicyBindingConfigurations
        {
            get;
            set;
        }
    }
}