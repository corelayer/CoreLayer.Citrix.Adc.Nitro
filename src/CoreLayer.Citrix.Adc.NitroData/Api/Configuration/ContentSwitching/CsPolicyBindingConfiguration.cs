using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsPolicyBindingConfiguration 
    {
        public string PolicyName { get; set; }
        [JsonPropertyName("cspolicy_cspolicylabel_binding")]
        public CsPolicyCsPolicyLabelBindingConfiguration[] CsPolicyCsPolicyLabelBindingConfigurations { get; set; }
        [JsonPropertyName("cspolicy_crvserver_binding")]
        public CsPolicyCrvServerBindingConfiguration[] CsPolicyCrvServerBindingConfigurations { get; set; }
        [JsonPropertyName("cspolicy_csvserver_binding")]
        public CsPolicyCsVServerBindingConfiguration[] CsPolicyCsVServerBindingConfigurations { get; set; }
    }
}