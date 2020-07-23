using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.ContentSwitching.Csvserver
{
    public class CsvserverStatResponse : NitroResponse
    {
        [JsonPropertyName("csvserver")]
        public CsvserverStats CsvserversStats { get; set; }
    }
}