using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsPbr6Stats
    {
        public string Name { get; set; }
        [JsonPropertyName("pbr6totpktsallowed")]public string Pbr6TotalPacketsAllowed { get; set; }
        [JsonPropertyName("pbr6pktsallowedrate")]public double? Pbr6PacketsAllowedRate { get; set; }
        [JsonPropertyName("pbr6totpktsdenied")]public string Pbr6TotalPacketsDenied { get; set; }
        [JsonPropertyName("pbr6pktsdeniedrate")]public double? Pbr6PacketsDeniedRate { get; set; }
        [JsonPropertyName("pbr6tothits")]public string Pbr6TotalHits { get; set; }
        [JsonPropertyName("pbr6hitsrate")]public double? Pbr6TotalHitsRate { get; set; }
        [JsonPropertyName("pbr6totmisses")]public string Pbr6TotalMisses { get; set; }
        [JsonPropertyName("pbr6missesrate")]public double? Pbr6MissesRate { get; set; }
        [JsonPropertyName("pbr6totnulldrop")]public string Pbr6TotalNullDrop { get; set; }
        [JsonPropertyName("pbr6nulldroprate")]public double? Pbr6NullDropRate { get; set; }
        [JsonPropertyName("pbr6perhits")]public string Pbr6Hits { get; set; }
        [JsonPropertyName("pbr6perhitsrate")]public double? Pbr6HitsRate { get; set; }
    }
}