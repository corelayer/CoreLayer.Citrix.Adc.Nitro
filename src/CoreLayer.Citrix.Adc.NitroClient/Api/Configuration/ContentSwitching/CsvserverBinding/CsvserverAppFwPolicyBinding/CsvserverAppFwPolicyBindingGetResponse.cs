using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFwPolicyBinding
{
    public class CsvserverAppFwPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_appfwpolicy_binding")]
        public CsvserverAppFwPolicyBindingConfiguration[] CsvserverAppFwPolicyBindingConfigurations { get; set; }
    }
}