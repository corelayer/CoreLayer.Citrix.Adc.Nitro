using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Policy;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("policystringmap_binding")]
        public PolicyStringMapBindingConfiguration PolicyStringMapBindingConfiguration { get; set; }
    }
}