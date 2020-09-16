using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsPolicyLabelConfiguration 
    {
        public string LabelName { get; set; }
        public string CsPolicyLabelType { get; set; }
        [JsonPropertyName("numpol")]public string NumberOfPolicies { get; set; }
        public string Hits { get; set; }
        public string PolicyName { get; set; }
        public string Priority { get; set; }
        public string TargetVServer { get; set; }
        public string GoToPriorityExpression { get; set; }
        public string LabelType { get; set; }
        [JsonPropertyName("invoke_labelname")]public string InvokeLabelName { get; set; }
    }
}