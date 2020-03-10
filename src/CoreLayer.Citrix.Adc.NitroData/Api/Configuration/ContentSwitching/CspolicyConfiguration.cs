using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CspolicyConfiguration : ICspolicyConfiguration
    {
        public string PolicyName { get; set; }
        public string Url { get; set; }
        public string Rule { get; set; }
        public string Domain { get; set; }
        public string Action { get; set; }
        public string LogAction { get; set; }
        public string NewName { get; set; }
        public string VsType { get; set; }
        public string Hits { get; set; }
        public string BindHits { get; set; }
        public string PiHits { get; set; }
        public string PiPolicyHits { get; set; }
        public string LabelName { get; set; }
        public string LabelType { get; set; }
        public string Priority { get; set; }
        public bool? ActivePolicy { get; set; }
        public string CspolicyType { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}