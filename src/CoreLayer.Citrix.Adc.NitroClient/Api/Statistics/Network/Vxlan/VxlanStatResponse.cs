using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Vxlan
{
    public class VxlanStatResponse : NitroResponse
    {
        [JsonPropertyName("vxlan")]public VxlanStats[] VxlanStatistics { get; set; }
    }
}