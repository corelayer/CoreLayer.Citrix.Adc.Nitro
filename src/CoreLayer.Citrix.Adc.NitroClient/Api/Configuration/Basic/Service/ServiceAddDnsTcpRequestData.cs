using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceAddDnsTcpRequestData : ServiceAddRequestData
    {
        public ServiceAddDnsTcpRequestData(string serviceName, string targetIpOrServer, int port) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "DNS_TCP";
        public override int Port { get; }
        
        public string Sp { get; set; } //SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}