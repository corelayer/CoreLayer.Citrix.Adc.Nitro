using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyAddRequestData : INitroRequestData
    {
        public string LabelName { get; set; }
        public string PolicyName { get; set; }
        public double? Priority { get; set; }
        public string TargetVServer { get; set; }
        public string GoToPriorityExpression { get; set; }
        public bool? Invoke { get; set; }
        public string LabelType { get; set; }
        [JsonPropertyName("invoke_labelname")]public string InvokeLabelName { get; set; }
    }
}