using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding
{
    public class CsvserverAppFlowPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_appflowpolicy_binding")]
        public CsvserverAppFlowPolicyBindingConfiguration[] CsvserverAppFlowPolicyBindingConfigurations { get; set; }
    }
}