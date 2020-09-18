using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicy_binding")]
        public CsPolicyBindingConfiguration[] CsPolicyBindingConfigurations { get; set; }
    }
}