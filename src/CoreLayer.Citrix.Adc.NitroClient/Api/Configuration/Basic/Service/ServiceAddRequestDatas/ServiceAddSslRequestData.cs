namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceAddRequestDatas
{
    public class ServiceAddSslRequestData : ServiceAddRequestData
    {
        public ServiceAddSslRequestData(string serviceName, string targetIpOrServer, int port) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "SSL";
        public override int Port { get; }
        
        public string ClearTextPort { get; set; } 
        public string CacheType { get; set; } 
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
        public string Cmp { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
    }
}