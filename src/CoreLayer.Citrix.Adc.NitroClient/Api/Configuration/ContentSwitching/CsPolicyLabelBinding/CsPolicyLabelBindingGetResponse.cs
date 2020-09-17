using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicylabel_binding")]
        public CsPolicyLabelBindingConfiguration[] CsPolicyLabelBindingConfigurations { get; set; }
    }
}