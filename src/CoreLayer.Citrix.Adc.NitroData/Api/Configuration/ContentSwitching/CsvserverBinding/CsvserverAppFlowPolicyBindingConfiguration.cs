using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverAppFlowPolicyBindingConfiguration
    {
        public string Priority { get; set; }
        public string BindPoint { get; set; }
        public string PolicyName { get; set; }
        public string LabalName { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("targetlbvserver")]public string TargetLoadBalancingVirtualServer { get; set; }
        public string GoToPriorityExpression { get; set; }
        public bool? Invoke { get; set; }
        public string LabelType { get; set; }
    }
}