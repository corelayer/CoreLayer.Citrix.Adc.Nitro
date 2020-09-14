using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingGetLbmonitorResponse : NitroResponse
    {
        [JsonPropertyName("service_lbmonitor_binding")]
        public ServiceBindingLbmonitorConfiguration[] ServiceBindingLbmonitorConfigurations { get; set; }
    }
}