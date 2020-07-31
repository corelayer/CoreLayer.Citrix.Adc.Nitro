using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNat
{
    public class RNatStatResponse : NitroResponse
    {
        [JsonPropertyName("rnat")]public RNatStats RNatStatistics { get; set; }
    }
}