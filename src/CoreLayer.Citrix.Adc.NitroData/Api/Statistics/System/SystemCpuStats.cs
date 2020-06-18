using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System
{
    public class SystemCpuStats
    {
        public string Id { get; set; }
        [JsonPropertyName("percpuuse")]public string CpuUsagePercent { get; set; }
    }
}