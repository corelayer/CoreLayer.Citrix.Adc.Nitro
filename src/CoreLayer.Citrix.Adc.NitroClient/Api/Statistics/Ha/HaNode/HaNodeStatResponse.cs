using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ha;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ha.HaNode
{
    public class HaNodeStatResponse : NitroResponse
    {
        [JsonPropertyName("hanode")]
        public HaNodeStats[] HaNodeStatistics { get; set; }
    }
}