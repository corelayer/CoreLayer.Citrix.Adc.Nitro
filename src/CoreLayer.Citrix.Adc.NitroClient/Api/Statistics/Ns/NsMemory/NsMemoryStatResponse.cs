using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsMemory
{
    public class NsMemoryStatResponse : NitroResponse
    {
        [JsonPropertyName("nsmemory")]public NsMemoryStats[] NsMemoryStatistics { get; set; }
    }
}