using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.VpnVserver
{
    public class VpnVserverStatResponse : NitroResponse
    {
        [JsonPropertyName("vpnvserver")]public VpnVserverStats VpnVserverStatistics { get; set; }
    }
}