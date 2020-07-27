using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.LbvserverBinding;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.AppFirewall;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFw
{
    public class AppFwStatResponse : NitroResponse
    {
        [JsonPropertyName("appfw")] public AppFwStats AppFwStatistics { get; set; }
    }
}