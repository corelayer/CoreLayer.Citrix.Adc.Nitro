using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Policy;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapPatternBinding
{
    public class PolicyStringMapPatternBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("policystringmap_pattern_binding")]
        public PolicyStringMapPatternBindingConfiguration[] PolicyStringMapPatternBindings { get; set; }
    }
}