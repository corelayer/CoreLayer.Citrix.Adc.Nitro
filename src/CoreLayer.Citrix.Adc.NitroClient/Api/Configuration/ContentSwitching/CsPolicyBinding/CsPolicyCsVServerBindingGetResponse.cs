using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsVServerBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicy_csvserver_binding")]
        public CsPolicyCsVServerBindingConfiguration[] CsPolicyCsVServerBindingConfigurations { get; set; }
    }
}