using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Responder
{
    public class ResponderPolicyLabelStats
    {
        public string LabelName { get; set; }
        [JsonPropertyName("pipolicylabelhits")]public string PolicyLabelHits { get; set; }
        [JsonPropertyName("pipolicylabelhitsrate")]public double? PolicyLabelHitsRate { get; set; }
    }
}