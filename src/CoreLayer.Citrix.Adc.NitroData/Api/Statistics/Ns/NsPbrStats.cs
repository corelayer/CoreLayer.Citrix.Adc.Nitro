using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsPbrStats
    {
        public string Name { get; set; }
        [JsonPropertyName("pbrtotpktsallowed")]public string PbrTotalPacketsAllowed { get; set; }
        [JsonPropertyName("pbrpktsallowedrate")]public double? PbrPacketsAllowedRate { get; set; }
        [JsonPropertyName("pbrtotpktsdenied")]public string PbrTotalPacketsDenied { get; set; }
        [JsonPropertyName("pbrpktsdeniedrate")]public double? PbrPacketsDeniedRate { get; set; }
        [JsonPropertyName("pbrtothits")]public string PbrTotalHits { get; set; }
        [JsonPropertyName("pbrhitsrate")]public double? PbrTotalHitsRate { get; set; }
        [JsonPropertyName("pbrtotmisses")]public string PbrTotalMisses { get; set; }
        [JsonPropertyName("pbrmissesrate")]public double? PbrMissesRate { get; set; }
        [JsonPropertyName("pbrtotnulldrop")]public string PbrTotalNullDrop { get; set; }
        [JsonPropertyName("pbrnulldroprate")]public double? PbrNullDropRate { get; set; }
        [JsonPropertyName("pbrperhits")]public string PbrHits { get; set; }
        [JsonPropertyName("pbrperhitsrate")]public double? PbrHitsRate { get; set; }
    }
}