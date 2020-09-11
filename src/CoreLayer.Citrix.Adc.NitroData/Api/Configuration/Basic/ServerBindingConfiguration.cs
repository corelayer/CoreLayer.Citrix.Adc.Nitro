using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServerBindingConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("server_gslbservicegroup_binding")]
        public ServerBindingGslbServiceGroupConfiguration[] ServerBindingGslbServiceGroups { get; set; }
        [JsonPropertyName("server_gslbservice_binding")]
        public ServerBindingGslbServiceConfiguration[] ServerBindingGslbServices { get; set; }
        [JsonPropertyName("server_servicegroup_binding")]
        public ServerBindingServiceGroupConfiguration[] ServerBindingServiceGroups { get; set; }
        [JsonPropertyName("server_service_binding")]
        public ServerBindingServiceConfiguration[] ServerBindingServices { get; set; }
    }
}