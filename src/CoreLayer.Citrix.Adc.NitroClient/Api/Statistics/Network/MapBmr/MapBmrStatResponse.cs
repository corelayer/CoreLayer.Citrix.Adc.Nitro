using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.MapBmr
{
    public class MapBmrStatResponse : NitroResponse
    {
        [JsonPropertyName("mapbmr")]public MapBmrStats[] MapBmrStatistics { get; set; }
    }
}