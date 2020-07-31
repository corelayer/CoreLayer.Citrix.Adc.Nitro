using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot
{
    public class BotPolicyLabelStats
    {
        public string LabelName { get; set; }
        [JsonPropertyName("pipolicylabelhits")]public string PolicyLabelHits { get; set; }
        [JsonPropertyName("pipolicylabelhitsrate")]public double? PolicyLabelHitsRate { get; set; }
    }
}