using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.TunnelIp6
{
    public class TunnelIp6StatResponse : NitroResponse
    {
        [JsonPropertyName("tunnelip6")]public TunnelIp6Stats[] TunnelIp6Statistics { get; set; }
    }
}