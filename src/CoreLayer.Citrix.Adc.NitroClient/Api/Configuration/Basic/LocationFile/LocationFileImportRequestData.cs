using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileImportRequestData : INitroRequestData
    {
        public string LocationFile { get; set; }
        [JsonPropertyName("src")]public string Source { get; set; }
    }
}