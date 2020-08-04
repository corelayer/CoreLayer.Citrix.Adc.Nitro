using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsLimitIdentifierStats
    {
        public string Name { get; set; }
        [JsonPropertyName("ratelmtobjhits")]public string RateLimitObjectHits { get; set; }
        [JsonPropertyName("ratelmtobjdrops")]public string RateLimitObjectDrops { get; set; }
        [JsonPropertyName("ratelmtsessionobjhits")]public string RateLimitSessionObjectHits { get; set; }
    }
}