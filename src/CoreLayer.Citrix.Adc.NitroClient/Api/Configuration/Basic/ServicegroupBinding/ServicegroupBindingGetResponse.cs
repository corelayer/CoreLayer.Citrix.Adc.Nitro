using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetResponse : NitroResponse
    {
        public string ServicegroupName { get; set; }
        [JsonPropertyName("servicegroup_lbmonitor_binding")]
        public ServicegroupBindingLbmonitorConfiguration[] ServicegroupBindingLbmonitorConfigurations { get; set; }
        [JsonPropertyName("servicegroup_servicegroupmember_binding")]
        public ServicegroupBindingServicegroupMemberConfiguration[] ServicegroupBindingServicegroupMemberConfigurations { get; set; }
        [JsonPropertyName("servicegroup_servicegroupentitymonbindings_binding")]
        public ServicegroupBindingServicegroupEntityMonBindingsConfiguration[] ServicegroupBindingServicegroupEntityMonBindingsConfigurations { get; set; }
        
    }
}