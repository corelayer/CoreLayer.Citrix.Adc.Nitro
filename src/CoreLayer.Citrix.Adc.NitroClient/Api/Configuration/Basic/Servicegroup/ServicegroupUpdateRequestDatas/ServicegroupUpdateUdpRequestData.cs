namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup.ServicegroupUpdateRequestDatas
{
    public class ServicegroupUpdateUdpRequestData : ServicegroupUpdateRequestData
    {
        public ServicegroupUpdateUdpRequestData(string servicegroupName) : base(servicegroupName)
        {
        }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; } 
        public string Sp { get; set; }
    }
}