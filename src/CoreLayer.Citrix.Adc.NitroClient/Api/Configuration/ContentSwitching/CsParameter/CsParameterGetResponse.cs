using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterGetResponse : NitroResponse
    {
        [JsonPropertyName("csparameter")]
        public CsParameterConfiguration CsParameterConfiguration { get; set; }
    }
}