using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsAcl6Stats
    {
        public string Acl6Name { get; set; }
        [JsonPropertyName("acl6totpktsbridged")]public string Acl6TotalPacketsBridged { get; set; }
        [JsonPropertyName("acl6pktsbridgedrate")]public double? Acl6PacketsBridgedRate { get; set; }
        [JsonPropertyName("acl6totpktsdenied")]public string Acl6TotalPacketsDenied { get; set; }
        [JsonPropertyName("acl6pktsdeniedrate")]public double? Acl6PacketsDeniedRate { get; set; }
        [JsonPropertyName("acl6totpktsallowed")]public string Acl6TotalPacketsAllowed { get; set; }
        [JsonPropertyName("acl6pktsallowedrate")]public double? Acl6PacketsAllowedRate { get; set; }
        [JsonPropertyName("acl6totpktsnat")]public string Acl6TotalPacketsNat { get; set; }
        [JsonPropertyName("acl6pktsnatrate")]public double? Acl6PacketsNatRate { get; set; }
        [JsonPropertyName("acl6tothits")]public string Acl6TotalHits { get; set; }
        [JsonPropertyName("acl6hitsrate")]public double? Acl6HitsRate { get; set; }
        [JsonPropertyName("acl6totmisses")]public string Acl6TotalMisses { get; set; }
        [JsonPropertyName("acl6missesrate")]public double? Acl6MissesRate { get; set; }
        [JsonPropertyName("acl6totcount")]public string Acl6TotalCount { get; set; }
        [JsonPropertyName("dfdacl6tothits")]public string DfAcl6TotalHits { get; set; }
        [JsonPropertyName("dfdacl6hitsrate")]public double? DfAcl6HitsRate { get; set; }
        [JsonPropertyName("dfdacl6totmisses")]public string DfAcl6TotalMisses { get; set; }
        [JsonPropertyName("dfdacl6missesrate")]public double? DfAcl6MissesRate { get; set; }
        [JsonPropertyName("dfdacl6totcount")]public string DfAcl6TotalCount { get; set; }
        [JsonPropertyName("acl6perhits")]public string Acl6PerHits { get; set; } //todo
        [JsonPropertyName("acl6perhitsrate")]public double? Acl6PerHitsRate { get; set; }
    }
}