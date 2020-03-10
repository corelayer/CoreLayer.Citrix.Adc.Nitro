using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicy")]
        public CspolicyConfiguration[] Cspolicies { get; set; }
    }
}