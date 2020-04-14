using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingServiceGetResponse
    {
        [JsonPropertyName("lbvserver_service_binding")]
        public LbvserverServiceBindingConfiguration[] LbvserverServiceBindings { get; set; }
    }
}