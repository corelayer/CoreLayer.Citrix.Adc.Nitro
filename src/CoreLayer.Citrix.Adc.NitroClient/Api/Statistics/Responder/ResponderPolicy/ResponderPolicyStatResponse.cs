using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Responder;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Responder.ResponderPolicy
{
    public class ResponderPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("responderpolicy")]
        public ResponderPolicyStats[] ResponderPolicyStatistics { get; set; }
    }
}