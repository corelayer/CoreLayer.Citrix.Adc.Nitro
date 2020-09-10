using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceUpdateSslTcpRequestData : ServiceUpdateRequestData
    {
        public ServiceUpdateSslTcpRequestData(string serviceName) : base(serviceName)
        {
        }
        
        public string Cacheable { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; } 
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}