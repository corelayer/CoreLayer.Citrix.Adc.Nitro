using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsAclStats
    {
        public string AclName { get; set; }
        [JsonPropertyName("acltotpktsbridged")]public string AclTotalPacketsBridged { get; set; }
        [JsonPropertyName("aclpktsbridgedrate")]public double? AclPacketsBridgedRate { get; set; }
        [JsonPropertyName("acltotpktsdenied")]public string AclTotalPacketsDenied { get; set; }
        [JsonPropertyName("aclpktsdeniedrate")]public double? AclPacketsDeniedRate { get; set; }
        [JsonPropertyName("acltotpktsallowed")]public string AclTotalPacketsAllowed { get; set; }
        [JsonPropertyName("aclpktsallowedrate")]public double? AclPacketsAllowedRate { get; set; }
        [JsonPropertyName("acltotpktsnat")]public string AclTotalPacketsNat { get; set; }
        [JsonPropertyName("aclpktsnatrate")]public double? AclPacketsNatRate { get; set; }
        [JsonPropertyName("acltothits")]public string AclTotalHits { get; set; }
        [JsonPropertyName("aclhitsrate")]public double? AclHitsRate { get; set; }
        [JsonPropertyName("acltotmisses")]public string AclTotalMisses { get; set; }
        [JsonPropertyName("aclmissesrate")]public double? AclMissesRate { get; set; }
        [JsonPropertyName("acltotcount")]public string AclTotalCount { get; set; }
        [JsonPropertyName("dfdacltothits")]public string DfAclTotalHits { get; set; }
        [JsonPropertyName("dfdaclhitsrate")]public double? DfAclHitsRate { get; set; }
        [JsonPropertyName("dfdacltotmisses")]public string DfAclTotalMisses { get; set; }
        [JsonPropertyName("dfdaclmissesrate")]public double? DfAclMissesRate { get; set; }
        [JsonPropertyName("dfdacltotcount")]public string DfAclTotalCount { get; set; }
        [JsonPropertyName("aclperhits")]public string AclPerHits { get; set; } //todo
        [JsonPropertyName("aclperhitsrate")]public double? AclPerHitsRate { get; set; }
    }
}