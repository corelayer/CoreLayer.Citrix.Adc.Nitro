using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingGetDosPolicyResponse : NitroResponse
    {
        [JsonPropertyName("service_dospolicy_binding")]
        public ServiceBindingDosPolicyConfiguration[] ServiceBindingDosPolicyConfigurations { get; set; }
    }
}