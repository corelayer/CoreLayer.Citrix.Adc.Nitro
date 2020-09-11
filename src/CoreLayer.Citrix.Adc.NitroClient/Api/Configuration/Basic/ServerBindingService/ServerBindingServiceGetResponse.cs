using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingService
{
    public class ServerBindingServiceGetResponse : NitroResponse
    {
        [JsonPropertyName("server_service_binding")]
        public ServerBindingServiceConfiguration[] ServerBindingServiceConfigurations { get; set; }
    }
}