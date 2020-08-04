using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsPartitionStats
    {
        public string PartitionName { get; set; }
        public string TotalTokenDrops { get; set; }
        public double? TokenDropsRate { get; set; }
        public string TotalDrops { get; set; }
        public double? DropsRate { get; set; }
        public string TotalConnectionDrops { get; set; }
        public double? ConnectionDropsRate { get; set; }
        public string CurrentConnections { get; set; }
        public string CurrentBandwidth { get; set; }
        public string MaxConnection { get; set; }
        public string MaxBandwidth { get; set; }
        public string MaxMemory { get; set; }
        [JsonPropertyName("memoryusagepcnt")]public double? MemoryUsagePercent { get; set; }
    }
}