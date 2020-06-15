using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemCpu
{
    public class SystemCpuStatResponse : NitroResponse
    {
        [JsonPropertyName("systemcpu")]
        public SystemCpuStats[] SystemCpuStatistics { get; set; }
    }
}