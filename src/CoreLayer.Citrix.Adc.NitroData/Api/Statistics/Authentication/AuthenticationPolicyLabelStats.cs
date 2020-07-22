using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication
{
    public class AuthenticationPolicyLabelStats
    {
         public string Name { get; set; }
         [JsonPropertyName("pipolicylabelhits")]public string PolicyLabelHits { get; set; }
         [JsonPropertyName("pipolicylabelhitsrate")] public double? PolicyLabelHitsRate { get; set; }
    }
}