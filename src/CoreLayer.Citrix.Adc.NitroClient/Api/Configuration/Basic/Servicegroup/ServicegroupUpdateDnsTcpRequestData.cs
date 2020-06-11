namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateDnsTcpRequestData : ServicegroupUpdateRequestData
    {
        public ServicegroupUpdateDnsTcpRequestData(string servicegroupName) : base(servicegroupName)
        {
        }
        
        public string Sp { get; set; }
        public string TcpProfileName { get; set; }
    }
}