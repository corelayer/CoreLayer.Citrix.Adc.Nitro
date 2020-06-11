namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateSslTcpRequestData : ServicegroupUpdateRequestData
    {
        public ServicegroupUpdateSslTcpRequestData(string servicegroupName) : base(servicegroupName)
        {
        }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
        public string TcpProfileName { get; set; }
    }
}