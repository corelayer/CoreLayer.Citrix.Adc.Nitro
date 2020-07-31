using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.VpnUrlPolicy
{
    public class VpnUrlPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("vpnurlpolicy")]public VpnUrlPolicyStats VpnUrlPolicyStatistics { get; set; }
    }
}