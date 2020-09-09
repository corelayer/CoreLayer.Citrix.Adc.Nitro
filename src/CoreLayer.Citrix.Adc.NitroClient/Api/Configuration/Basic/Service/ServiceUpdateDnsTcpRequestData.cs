using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceUpdateDnsTcpRequestData : ServiceUpdateRequestData
    {
        public ServiceUpdateDnsTcpRequestData(string serviceName) : base(serviceName)
        {
        }
        public string Sp { get; set; }//SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}