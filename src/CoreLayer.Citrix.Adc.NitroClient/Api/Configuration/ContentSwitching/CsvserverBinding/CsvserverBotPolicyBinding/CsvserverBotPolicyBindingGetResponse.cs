using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding
{
    public class CsvserverBotPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_botpolicy_binding")]
        public CsvserverBotPolicyBindingConfiguration[] CsvserverBotPolicyBindingConfigurations { get; set; }
    }
}