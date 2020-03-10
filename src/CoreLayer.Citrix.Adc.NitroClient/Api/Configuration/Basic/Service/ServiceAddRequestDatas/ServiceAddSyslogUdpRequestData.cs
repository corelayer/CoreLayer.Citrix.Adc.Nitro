namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceAddRequestDatas
{
    public class ServiceAddSyslogUdpRequestData : ServiceAddRequestData
    {
        public ServiceAddSyslogUdpRequestData(string serviceName, string targetIpOrServer, int port) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "SYSLOGUDP";
        public override int Port { get; }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
    }
}