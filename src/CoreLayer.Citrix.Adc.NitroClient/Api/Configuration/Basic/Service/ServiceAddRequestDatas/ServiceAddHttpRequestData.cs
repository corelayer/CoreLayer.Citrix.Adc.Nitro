namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceAddRequestDatas
{
    public class ServiceAddHttpRequestData : ServiceAddRequestData
    {
        public ServiceAddHttpRequestData(string serviceName, string targetIpOrServer, int port = 80) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "HTTP";
        public override int Port { get; }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
        public string Cmp { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
    }
}