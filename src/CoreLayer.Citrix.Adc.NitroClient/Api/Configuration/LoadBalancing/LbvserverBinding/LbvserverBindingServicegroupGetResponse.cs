using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingServicegroupGetResponse
    {
        [JsonPropertyName("lbvserver_servicegroup_binding")]
        public LbvserverServicegroupBindingConfiguration[] LbvserverServicegroupBindings { get; set; }
    }
}