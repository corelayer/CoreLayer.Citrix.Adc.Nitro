using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceAddSslBridgeRequestData : ServiceAddRequestData
    {
        public ServiceAddSslBridgeRequestData(string serviceName, string targetIpOrServer, int port) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "SSL_BRIDGE";
        public override int Port { get; }
        
        public string Cacheable { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; } 
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}