using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.AppFirewall;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicy
{
    public class AppFwPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("appfwpolicy")]public AppFwPolicyStats[] AppFwPolicyStatistics { get; set; }
    }
}