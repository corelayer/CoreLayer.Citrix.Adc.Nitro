using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionGetResponse : NitroResponse
    {
        [JsonPropertyName("csaction")]
        public CsactionConfiguration[] Csactions { get; set; }
    }
}