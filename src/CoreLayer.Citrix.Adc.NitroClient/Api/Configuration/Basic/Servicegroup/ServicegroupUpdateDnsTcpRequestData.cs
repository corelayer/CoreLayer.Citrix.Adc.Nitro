using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateDnsTcpRequestData : ServicegroupUpdateRequestData
    {
        public ServicegroupUpdateDnsTcpRequestData(string servicegroupName) : base(servicegroupName)
        {
        }
        
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}