using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCrvServerBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicy_crvserver_binding")]
        public CsPolicyCrvServerBindingConfiguration[] CsPolicyCrvServerBindingConfigurations { get; set; }
    }
}