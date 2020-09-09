using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceAddSslTcpRequestData : ServiceAddRequestData
    {
        public ServiceAddSslTcpRequestData(string serviceName, string targetIpOrServer, int port) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "SSL_TCP";
        public override int Port { get; }
        
        public string ClearTextPort { get; set; } 
        public string CacheType { get; set; } 
        public string Cacheable { get; set; }
        public string Sc { get; set; }//SureConnect { get; set; } 
        public string Sp { get; set; }//SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}