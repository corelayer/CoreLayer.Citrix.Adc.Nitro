using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsactionConfiguration //: ICsactionConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("targetlbvserver")]public string TargetLoadBalancingVirtualServer { get; set; }
        [JsonPropertyName("targetvserver")]public string TargetVirtualServer { get; set; }
        [JsonPropertyName("targetvserverexpr")]public string TargetVirtualServerExpression { get; set; }
        public string Comment { get; set; }
        public string NewName { get; set; }
        public string Hits { get; set; }
        public string ReferenceCount { get; set; }
        [JsonPropertyName("undefhits")]public string UndefinedHits { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}