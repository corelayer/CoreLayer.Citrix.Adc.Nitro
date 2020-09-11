using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServerBindingGslbServiceConfiguration
    {
        public string Name { get; set; }
        public string ServiceName { get; set; }
        [JsonPropertyName("serviceipstr")]public string ServiceIpsString { get; set; }
        [JsonPropertyName("svctype")]public string ServiceType { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        public int? Port { get; set; }
        public string ServiceIpAddress { get; set; }
    }
}