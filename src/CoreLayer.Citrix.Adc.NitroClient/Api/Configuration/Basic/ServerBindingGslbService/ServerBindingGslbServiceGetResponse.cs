using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingGslbService
{
    public class ServerBindingGslbServiceGetResponse : NitroResponse
    {
        [JsonPropertyName("server_gslbservice_binding")]
        public ServerBindingGslbServiceConfiguration[] ServerBindingGslbServiceConfigurations { get; set; }
    }
}