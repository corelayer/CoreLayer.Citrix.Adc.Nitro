using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionUpdateRequestData : INitroRequestData
    {
        public string Name { get; }

        public CsactionUpdateRequestData(string csActionName)
        {
            Name = csActionName;
        }
        
        [JsonPropertyName("targetlbvserver")]public string TargetLoadBalancingVirtualServer { get; set; }
        [JsonPropertyName("targetvserver")]public string TargetVirtualServer { get; set; }
        [JsonPropertyName("targetvserverexpr")]public string TargetVirtualServerExpression { get; set; }
        public string Comment { get; set; }
    }
}