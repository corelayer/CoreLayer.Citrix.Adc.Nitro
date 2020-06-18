using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System
{
    public class SystemMemoryStats
    {
            [JsonPropertyName("cacmemmaxmemlimitpcnt")]public double? CacheMemoryMaxMemoryLimitPercent { get; set; }
            [JsonPropertyName("cacmemmaxmemlimit")]public string CacheMemoryMaxMemoryLimit { get; set; }
            [JsonPropertyName("shmemerrallocfailed")]public string SharedMemoryAllocationFailed { get; set; }
            [JsonPropertyName("shmemallocpcnt")]public double? SharedMemoryAllocationPercent { get; set; }
            [JsonPropertyName("shmemallocinmb")]public string SharedMemoryAllocatedInMb { get; set; }
            [JsonPropertyName("shmemtotinmb")]public string SharedMemoryTotalInMb { get; set; }
            [JsonPropertyName("memtotallocfailed")]public string MemoryTotalAllocatedFailed { get; set; }
            [JsonPropertyName("memtotfree")]public string MemoryTotalFree { get; set; }
            [JsonPropertyName("memusagepcnt")]public double? MemoryUsagePercent { get; set; }
            [JsonPropertyName("memtotuseinmb")]public string MemoryTotalUseInMb { get; set; }
            [JsonPropertyName("memtotallocpcnt")]public double? MemoryTotalAllocatedPercent { get; set; }
            [JsonPropertyName("memtotallocmb")]public string MemoryTotalAllocatedMb { get; set; }
            [JsonPropertyName("memtotinmb")]public string MemoryTotalInMb { get; set; }
            [JsonPropertyName("memtotavail")]public string MemoryTotalAvailable { get; set; }
            [JsonPropertyName("cacmemmaxsyslimitmb")]public string CacheMemoryMaxSystemLimitMb { get; set; }
    }
}