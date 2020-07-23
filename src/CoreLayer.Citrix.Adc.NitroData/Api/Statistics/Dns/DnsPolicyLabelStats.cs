using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns
{
    public class DnsPolicyLabelStats
    {
        public string LabelName { get; set; }
        [JsonPropertyName("pipolicylabelhits")]public string PolicyLabelHits { get; set; }
        [JsonPropertyName("pipolicylabelhitsrate")]public double? PolicyLabelHitsRate { get; set; }
    }
}