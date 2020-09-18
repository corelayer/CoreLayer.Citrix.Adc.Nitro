using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingGetScPolicyResponse : NitroResponse
    {
        [JsonPropertyName("service_scpolicy_binding")]
        public ServiceBindingScPolicyConfiguration[] ServiceBindingScPolicyConfigurations { get; set; }
    }
}