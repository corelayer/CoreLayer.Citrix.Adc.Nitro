using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsactionConfiguration : ICsactionConfiguration
    {
        public string Name { get; set; }
        public string TargetLbvserver { get; set; }
        public string TargetVserver { get; set; }
        public string TargetvserverExpr { get; set; }
        public string Comment { get; set; }
        public string NewName { get; set; }
        public string Hits { get; set; }
        public string ReferenceCount { get; set; }
        public string UndefHits { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}