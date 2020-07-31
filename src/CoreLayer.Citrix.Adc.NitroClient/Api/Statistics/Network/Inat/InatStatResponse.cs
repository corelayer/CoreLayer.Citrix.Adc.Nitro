using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Inat
{
    public class InatStatResponse : NitroResponse
    {
        [JsonPropertyName("inat")]public InatStats[] InatStatistics { get; set; }
    }
}