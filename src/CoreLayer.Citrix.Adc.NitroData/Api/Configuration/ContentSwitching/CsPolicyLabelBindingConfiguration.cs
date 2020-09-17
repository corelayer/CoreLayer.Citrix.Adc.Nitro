using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsPolicyLabelBindingConfiguration
    {
        public string LabelName { get; set; }
        [JsonPropertyName("cspolicylabel_cspolicy_binding")]
        public CsPolicyLabelBindingCsPolicyConfiguration[] CsPolicyLabelBindingCsPolicyConfigurations { get; set; }
    }
}