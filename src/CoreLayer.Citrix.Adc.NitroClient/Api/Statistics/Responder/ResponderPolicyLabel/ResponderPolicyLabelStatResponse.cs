using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Responder;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Responder.ResponderPolicyLabel
{
    public class ResponderPolicyLabelStatResponse : NitroResponse
    {
        [JsonPropertyName("responderpolicylabel")]
        public ResponderPolicyLabelStats ResponderPolicyLabelStatistics { get; set; }
    }
}