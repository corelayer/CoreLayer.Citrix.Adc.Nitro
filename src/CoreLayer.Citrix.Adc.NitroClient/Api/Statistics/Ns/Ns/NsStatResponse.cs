using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.Ns
{
    public class NsStatResponse : NitroResponse
    {
        [JsonPropertyName("ns")]
        public NsStats[] NsStatistics { get; set; }
    }
}