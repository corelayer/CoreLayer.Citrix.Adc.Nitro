using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Rewrite;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Rewrite.RewritePolicyLabel
{
    public class RewritePolicyLabelStatResponse : NitroResponse
    {
        [JsonPropertyName("rewritepolicylabel")]
        public RewritePolicyLabelStats RewritePolicyLabelStatistics { get; set; }
    }
}