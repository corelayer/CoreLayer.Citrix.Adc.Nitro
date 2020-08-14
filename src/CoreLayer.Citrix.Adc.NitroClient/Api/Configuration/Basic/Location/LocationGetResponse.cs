using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location
{
    public class LocationGetResponse : NitroResponse
    {
        [JsonPropertyName("location")]public LocationConfiguration Location { get; set; }
    }
}