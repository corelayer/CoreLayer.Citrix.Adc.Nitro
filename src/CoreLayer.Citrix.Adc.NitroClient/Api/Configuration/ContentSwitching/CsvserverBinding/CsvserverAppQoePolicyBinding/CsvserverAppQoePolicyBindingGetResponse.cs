using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAppQoePolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_appqoepolicy_binding")]
        public CsvserverAppQoePolicyBindingConfiguration[] CsvserverAppQoePolicyBindingConfigurations { get; set; }
    }
}