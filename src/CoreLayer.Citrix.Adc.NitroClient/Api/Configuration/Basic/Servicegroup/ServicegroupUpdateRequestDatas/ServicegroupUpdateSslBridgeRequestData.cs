namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup.ServicegroupUpdateRequestDatas
{
    public class ServicegroupUpdateSslBridgeRequestData : ServicegroupUpdateRequestData
    {
        public ServicegroupUpdateSslBridgeRequestData(string servicegroupName) : base(servicegroupName)
        {
        }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
        public string TcpProfileName { get; set; }
    }
}