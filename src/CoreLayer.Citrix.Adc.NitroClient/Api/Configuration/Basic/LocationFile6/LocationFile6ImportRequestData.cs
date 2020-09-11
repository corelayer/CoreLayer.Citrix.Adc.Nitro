using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6ImportRequestData
    {
        public string LocationFile { get; set; }
        [JsonPropertyName("src")]public string Source { get; set; }
    }
}