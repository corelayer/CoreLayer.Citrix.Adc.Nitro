using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Vlan
{
    public class VlanStatResponse : NitroResponse
    {
        [JsonPropertyName("vlan")]
        public VlanStats VlanStatistics { get; set; }
    }
}