namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service.ServiceUpdateRequestDatas
{
    public class ServiceUpdateDnsTcpRequestData : ServiceUpdateRequestData
    {
        public ServiceUpdateDnsTcpRequestData(string serviceName) : base(serviceName)
        {
        }
        public string Sp { get; set; }
        public string TcpProfileName { get; set; }
    }
}