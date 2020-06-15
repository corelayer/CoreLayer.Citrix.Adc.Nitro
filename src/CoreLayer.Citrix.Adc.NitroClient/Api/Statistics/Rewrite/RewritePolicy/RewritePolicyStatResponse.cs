using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Rewrite;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Rewrite.RewritePolicy
{
    public class RewritePolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("rewritepolicy")]
        public RewritePolicyStats[] RewritePolicyStatistics { get; set; }
    }
}