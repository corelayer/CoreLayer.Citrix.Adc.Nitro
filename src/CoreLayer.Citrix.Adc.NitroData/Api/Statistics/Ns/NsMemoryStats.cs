using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsMemoryStats
    {
        public string Pool { get; set; }
        [JsonPropertyName("memcurinkb")]public string MemoryCurrentAvailableInKb { get; set; }
        [JsonPropertyName("allocf")]public double? AllocationFailure { get; set; }
        [JsonPropertyName("memcurallocper")]public double? MemoryCurrentFeatureAllocatedPercent { get; set; }
    }
}