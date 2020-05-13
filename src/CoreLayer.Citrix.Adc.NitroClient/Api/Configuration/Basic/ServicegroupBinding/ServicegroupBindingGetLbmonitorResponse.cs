using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetLbmonitorResponse : NitroResponse
    {
        [JsonPropertyName("servicegroup_lbmonitor_binding")]
        public ServicegroupBindingLbmonitorConfiguration[] ServicegroupBindingLbmonitorConfigurations { get; set; }
    }
}