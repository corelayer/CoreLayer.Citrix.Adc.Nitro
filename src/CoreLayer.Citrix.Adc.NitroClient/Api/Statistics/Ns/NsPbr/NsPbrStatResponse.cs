using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPbr
{
    public class NsPbrStatResponse : NitroResponse
    {
        [JsonPropertyName("nspbr")]public NsPbrStats[] NsPbrStatistics { get; set; }
    }
}