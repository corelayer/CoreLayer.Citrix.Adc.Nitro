using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemMemory
{
    public class SystemMemoryStatResponse : NitroResponse
    {
        [JsonPropertyName("systemmemory")]
        public SystemMemoryStats SystemMemoryStatistics { get; set; }
    }
}