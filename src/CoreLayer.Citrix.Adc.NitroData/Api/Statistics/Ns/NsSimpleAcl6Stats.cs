using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsSimpleAcl6Stats
    {
        [JsonPropertyName("sacl6tothits")]public string SimpleAcl6TotalHits { get; set; }
        [JsonPropertyName("sacl6hitsrate")]public double? SimpleAcl6HitsRate { get; set; }
        [JsonPropertyName("sacl6totmisses")]public string SimpleAcl6TotalMisses { get; set; }
        [JsonPropertyName("sacl6missesrate")]public double? SimpleAcl6MissesRate { get; set; }
        [JsonPropertyName("sacl6scount")]public string SimpleAcl6sCount { get; set; }
        [JsonPropertyName("sacl6totpktsallowed")]public string SimpleAcl6TotalPacketsAllowed { get; set; }
        [JsonPropertyName("sacl6pktsallowedrate")]public double? SimpleAcl6PacketsAllowedRate { get; set; }
        [JsonPropertyName("sacl6totpktsbridged")]public string SimpleAcl6TotalPacketsBridged { get; set; }
        [JsonPropertyName("sacl6pktsbridgedrate")]public double? SimpleAcl6PacketsBridgedRate { get; set; }
        [JsonPropertyName("sacl6totpktsdenied")]public string SimpleAcl6TotalPacketsDenied { get; set; }
        [JsonPropertyName("sacl6pktsdeniedrate")]public double? SimpleAcl6PacketsDenied { get; set; }
    }
}