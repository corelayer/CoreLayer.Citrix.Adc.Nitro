using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceAddSyslogTcpRequestData : ServiceAddRequestData
    {
        public ServiceAddSyslogTcpRequestData(string serviceName, string targetIpOrServer, int port) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "SYSLOGTCP";
        public override int Port { get; }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; }//SureConnect { get; set; } 
        public string Sp { get; set; }//SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}