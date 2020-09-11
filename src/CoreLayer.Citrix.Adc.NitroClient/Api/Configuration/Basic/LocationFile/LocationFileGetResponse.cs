using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileGetResponse : NitroResponse
    {
        [JsonPropertyName("locationfile")]public LocationFileConfiguration[] LocationFiles { get; set; }
    }
}