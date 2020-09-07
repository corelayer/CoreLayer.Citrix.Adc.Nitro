using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6GetResponse : NitroResponse
    {
        [JsonPropertyName("locationfile6")]public LocationFile6Configuration[] LocationFile6Configurations { get; set; }
    }
}