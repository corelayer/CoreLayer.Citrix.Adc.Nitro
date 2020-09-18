using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsPolicyLabelBindingCsPolicyConfiguration
    {
        public string Priority { get; set; }
        public string PolicyName { get; set; }
        public string LabelName { get; set; }
        public string TargetVServer { get; set; }
        [JsonPropertyName("invoke_labelname")]public string InvokeLabelName { get; set; }
        public string GoToPriorityExpression { get; set; }
        public string Invoke { get; set; }
        public string LabelType { get; set; }
    }
}