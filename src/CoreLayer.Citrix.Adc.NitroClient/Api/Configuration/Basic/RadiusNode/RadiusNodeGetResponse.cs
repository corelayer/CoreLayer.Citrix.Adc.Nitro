using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeGetResponse : NitroResponse
    {
        [JsonPropertyName("radiusnode")]public RadiusNodeConfiguration[] RadiusNodeConfigurations { get; set; }
    }
}