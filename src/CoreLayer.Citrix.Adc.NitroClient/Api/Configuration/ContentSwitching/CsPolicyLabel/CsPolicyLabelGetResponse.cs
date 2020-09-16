using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelGetResponse : NitroResponse
    {
        [JsonPropertyName("cspolicylabel")]
        public CsPolicyLabelConfiguration CsPolicyLabelConfiguration { get; set; }
    }
}