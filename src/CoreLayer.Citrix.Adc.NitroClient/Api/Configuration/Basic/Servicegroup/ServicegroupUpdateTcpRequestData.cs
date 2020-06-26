using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateTcpRequestData : ServicegroupUpdateRequestData
    {
        public ServicegroupUpdateTcpRequestData(string servicegroupName) : base(servicegroupName)
        {
        }
        
        public string Cacheable { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; } 
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        public string TcpProfileName { get; set; }
    }
}