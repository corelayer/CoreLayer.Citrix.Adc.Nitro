using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterGetResponse : NitroResponse
    {
        [JsonPropertyName("locationparameter")]public LocationParameterConfiguration LocationParameter { get; set; }
    }
}