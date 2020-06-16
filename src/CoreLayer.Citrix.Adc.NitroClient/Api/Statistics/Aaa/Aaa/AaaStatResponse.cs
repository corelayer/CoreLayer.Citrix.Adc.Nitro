using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Aaa;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Aaa.Aaa
{
    public class AaaStatResponse : NitroResponse
    {
        [JsonPropertyName("aaa")]
        public AaaStats AaaStatistics { get; set; }
    }
}