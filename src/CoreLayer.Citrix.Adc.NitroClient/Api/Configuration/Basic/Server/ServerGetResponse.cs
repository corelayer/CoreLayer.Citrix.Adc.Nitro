using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerGetResponse : NitroResponse
    {
        [JsonPropertyName("server")]
        public ServerConfiguration[] Servers { get; set; }
    }
}