using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.InatSession
{
    public class InatSessionStatResponse : NitroResponse
    {
        [JsonPropertyName("inatsession")]public InatSessionStats[] InatSessionStatistics { get; set; }
    }
}