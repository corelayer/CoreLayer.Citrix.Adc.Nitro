namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateHttpRequestData : ServicegroupUpdateRequestData
    {
        public ServicegroupUpdateHttpRequestData(string servicegroupName) : base(servicegroupName)
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