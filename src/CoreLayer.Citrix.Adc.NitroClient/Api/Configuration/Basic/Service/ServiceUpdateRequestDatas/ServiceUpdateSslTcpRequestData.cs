namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceUpdateRequestDatas
{
    public class ServiceUpdateSslTcpRequestData : ServiceUpdateRequestData
    {
        public ServiceUpdateSslTcpRequestData(string serviceName) : base(serviceName)
        {
        }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
        public string TcpProfileName { get; set; }
    }
}