using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic.Servicegroup;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupGetResponse : NitroResponse
    {
        [JsonPropertyName("servicegroup")]
        public ServicegroupConfiguration[] Servicegroups { get; set; }
    }
}