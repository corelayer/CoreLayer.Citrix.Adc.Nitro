using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.AppFirewall
{
    public class AppFwPolicyStats
    {
        public string Name { get; set; }
        [JsonPropertyName("pipolicyhits")]public string PolicyHits { get; set; }
        [JsonPropertyName("pipolicyhitsrate")]public double? PolicyHitsRate { get; set; }
        [JsonPropertyName("pipolicyundefhits")]public string PolicyUndefinedHits { get; set; }
        [JsonPropertyName("pipolicyundefhitsrate")]public double? PolicyUndefinedHitsRate { get; set; }
    }
}