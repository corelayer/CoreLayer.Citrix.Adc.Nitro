using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Bridge
{
    public class BridgeStatResponse : NitroResponse
    {
        [JsonPropertyName("bridge")]public BridgeStats BridgeStatistics { get; set; }
    }
}