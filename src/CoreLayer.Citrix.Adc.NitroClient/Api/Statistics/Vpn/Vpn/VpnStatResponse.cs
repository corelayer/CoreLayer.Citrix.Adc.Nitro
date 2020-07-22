using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.Vpn
{
    public class VpnStatResponse : NitroResponse
    {
        [JsonPropertyName("vpn")]public VpnStats[] VpnStatistics { get; set; }
            
    }
}