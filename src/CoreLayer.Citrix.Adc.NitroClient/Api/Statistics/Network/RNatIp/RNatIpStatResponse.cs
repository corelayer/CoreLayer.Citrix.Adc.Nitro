using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNatIp
{
    public class RNatIpStatResponse : NitroResponse
    {
        [JsonPropertyName("rnatip")]public RNatIpStats[] RNatIpStatistics { get; set; }
    }
}