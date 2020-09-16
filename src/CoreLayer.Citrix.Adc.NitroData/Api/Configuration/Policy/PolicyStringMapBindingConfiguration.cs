using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Policy
{
    public class PolicyStringMapBindingConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("policystringmap_pattern_binding")]
        public PolicyStringMapPatternBindingConfiguration[] PolicyStringMapPatternBindingConfigurations { get; set; }
    }
}