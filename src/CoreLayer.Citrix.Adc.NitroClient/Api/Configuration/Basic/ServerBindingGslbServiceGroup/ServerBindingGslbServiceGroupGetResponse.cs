using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingGslbServiceGroup
{
    public class ServerBindingGslbServiceGroupGetResponse : NitroResponse
    {
        [JsonPropertyName("server_gslbservicegroup_binding")]
        public ServerBindingGslbServiceGroupConfiguration[] ServerBindingGslbServiceGroups { get; set; }
    }
}