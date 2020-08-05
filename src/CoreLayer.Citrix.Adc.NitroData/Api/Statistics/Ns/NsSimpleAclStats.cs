using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsSimpleAclStats
    {
        [JsonPropertyName("sacltothits")]public string SimpleAclTotalHits { get; set; }
        [JsonPropertyName("saclhitsrate")]public double? SimpleAclHitsRate { get; set; }
        [JsonPropertyName("sacltotmisses")]public string SimpleAclTotalMisses { get; set; }
        [JsonPropertyName("saclmissesrate")]public double? SimpleAclMissesRate { get; set; }
        [JsonPropertyName("saclscount")]public string SimpleAclsCount { get; set; }
        [JsonPropertyName("sacltotpktsallowed")]public string SimpleAclTotalPacketsAllowed { get; set; }
        [JsonPropertyName("saclpktsallowedrate")]public double? SimpleAclPacketsAllowedRate { get; set; }
        [JsonPropertyName("sacltotpktsbridged")]public string SimpleAclTotalPacketsBridged { get; set; }
        [JsonPropertyName("saclpktsbridgedrate")]public double? SimpleAclPacketsBridgedRate { get; set; }
        [JsonPropertyName("sacltotpktsdenied")]public string SimpleAclTotalPacketsDenied { get; set; }
        [JsonPropertyName("saclpktsdeniedrate")]public double? SimpleAclPacketsDenied { get; set; }
    }
}