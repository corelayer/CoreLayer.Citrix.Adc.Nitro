using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn
{
    public class VpnUrlPolicyStats
    {
        public string Name { get; set; }
        [JsonPropertyName("pipolicyhits")]public string PolicyHits { get; set; }
        [JsonPropertyName("pipolicyhitsrate")]public double? PolicyHitsRate { get; set; }
    }
}