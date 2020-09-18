using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsPolicyLabelBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicy_cspolicylabel_binding")]
        public CsPolicyCsPolicyLabelBindingConfiguration[] CsPolicyCsPolicyLabelBindingConfigurations { get; set; }
    }
}