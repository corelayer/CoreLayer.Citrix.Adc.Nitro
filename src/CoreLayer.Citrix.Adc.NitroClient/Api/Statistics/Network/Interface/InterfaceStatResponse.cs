using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Interface
{
    public class InterfaceStatResponse : NitroResponse
    {
        [JsonPropertyName("interface")]
        public InterfaceStats InterfaceStatistics { get; set; }
    }
}