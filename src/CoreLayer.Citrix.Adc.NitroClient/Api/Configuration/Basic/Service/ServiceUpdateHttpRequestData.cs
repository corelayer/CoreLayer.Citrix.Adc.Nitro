namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceUpdateHttpRequestData : ServiceUpdateRequestData
    {
        public ServiceUpdateHttpRequestData(string serviceName) : base(serviceName)
        {
        }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
        public string Cmp { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
    }
}