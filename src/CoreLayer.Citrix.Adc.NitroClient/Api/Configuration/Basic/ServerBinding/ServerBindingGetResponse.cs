using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBinding
{
    public class ServerBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("server_binding")]public ServerBindingConfiguration ServerBinding { get; set; }
    }
}