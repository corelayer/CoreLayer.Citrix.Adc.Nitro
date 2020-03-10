namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceUpdateRequestDatas
{
    public class ServiceUpdateSyslogTcpRequestData : ServiceUpdateRequestData
    {
        public ServiceUpdateSyslogTcpRequestData(string serviceName) : base(serviceName)
        {
        }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
        public string TcpProfileName { get; set; }
    }
}