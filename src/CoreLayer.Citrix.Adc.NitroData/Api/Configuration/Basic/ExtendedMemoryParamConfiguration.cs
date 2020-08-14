using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ExtendedMemoryParamConfiguration
    {
        [JsonPropertyName("memlimitactive")]public double? MemoryLimitActive { get; set; }
        [JsonPropertyName("maxmemlimit")]public double? MaxMemoryLimit { get; set; }
        [JsonPropertyName("memlimit")]public double? MemoryLimit { get; set; }
        [JsonPropertyName("minrequiredmemory")]public double? MinRequiredMemory { get; set; }
    }
}