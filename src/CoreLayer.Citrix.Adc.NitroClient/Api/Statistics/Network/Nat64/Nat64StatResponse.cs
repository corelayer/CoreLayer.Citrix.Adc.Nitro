using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Nat64
{
    public class Nat64StatResponse : NitroResponse
    {
        [JsonPropertyName("nat64")]public Nat64Stats Nat64Statistics { get; set; }
    }
}