using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNat6
{
    public class RNat6StatResponse : NitroResponse
    {
        [JsonPropertyName("rnat6")]public RNat6Stats RNat6Statistics { get; set; }
    }
}