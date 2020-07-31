using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.TunnelIp
{
    public class TunnelIpStatResponse : NitroResponse
    {
        [JsonPropertyName("tunnelip")]public TunnelIpStats[] TunnelIpStatistics { get; set; }
    }
}