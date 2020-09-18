using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicylabel_cspolicy_binding")]
        public CsPolicyLabelBindingCsPolicyConfiguration[] CsPolicyLabelBindingCsPolicyConfigurations { get; set; }
    }
}