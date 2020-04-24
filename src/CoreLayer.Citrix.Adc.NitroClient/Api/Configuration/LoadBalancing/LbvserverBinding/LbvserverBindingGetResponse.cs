using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("lbvserver_binding")]
        public LbvserverBindingConfiguration[] LbvserverBindings { get; set; }
    }
}