using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsPolicyCsVServerBindingConfiguration
    {
        public string PolicyName { get; set; }
        public string Domain { get; set; }
        public string Priority { get; set; }
        public string Hits { get; set; }
        public string Url { get; set; }
        [JsonPropertyName("pipolicyhits")]public string PolicyHits { get; set; }
        public string LabelType { get; set; }
        public string LabelName { get; set; }
        public string PiHits { get; set; }
        public string Action { get; set; }
    }
}