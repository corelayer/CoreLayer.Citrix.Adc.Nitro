using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingServiceGroup
{
    public class ServerBindingServiceGroupGetResponse : NitroResponse
    {
        [JsonPropertyName("server_servicegroup_binding")]
        public ServerBindingServiceGroupConfiguration[] ServerBindingServiceGroups { get; set; }
    }
}