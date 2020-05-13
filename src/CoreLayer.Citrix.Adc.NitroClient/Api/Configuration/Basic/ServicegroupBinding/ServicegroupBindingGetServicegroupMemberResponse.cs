using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetServicegroupMemberResponse : NitroResponse
    {
        [JsonPropertyName("servicegroup_servicegroupmember_binding")]
        public ServicegroupBindingServicegroupMemberConfiguration[] ServicegroupBindingServicegroupMemberConfigurations { get; set; }
    }
}