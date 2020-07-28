using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.AppFirewall;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicyLabel
{
    public class AppFwPolicyLabelStatResponse : NitroResponse
    {
        [JsonPropertyName("appfwpolicylabel")]public AppFwPolicyLabelStats[] AppFwPolicyLabelStatistics { get; set; }
    }
}