using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingAddRequestData : INitroRequestData
    {
        public string Name { get; set; }
        public string PolicyName { get; set; }
        [JsonPropertyName("targetlbvserver")]public string TargetLoadBalancingVirtualServer { get; set; }
        public double? Priority { get; set; }
        public string GoToPriorityExpression { get; set; }
        public string BindPoint { get; set; }
        public bool? Invoke { get; set; }
        public string LabelType { get; set; }
        public string LabelName { get; set; }
    }
}