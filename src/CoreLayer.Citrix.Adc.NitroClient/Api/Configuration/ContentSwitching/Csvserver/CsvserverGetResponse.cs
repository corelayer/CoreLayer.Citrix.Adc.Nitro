using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver")]
        public CsvserverConfiguration[] Csvservers { get; set; }
    }
}