using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddCsPolicyRequestData : INitroRequestData
    {
        public string Name { get; }
        public string PolicyName { get; set; }
        public string TargetLbvserver { get; set; }
        public double? Priority { get; set; }
        public string GoToPriorityExpression { get; set; }
        public string BindPoint { get; set; }
        public bool? Invoke { get; set; }
        public string LabelType { get; set; }
        public string LabelName { get; set; }

        public CsvserverBindingAddCsPolicyRequestData(string csvserverName)
        {
            Name = csvserverName;
        }
    }
}