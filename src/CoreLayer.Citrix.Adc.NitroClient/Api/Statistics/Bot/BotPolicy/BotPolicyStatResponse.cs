using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotPolicy
{
    public class BotPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("botpolicy")]public BotPolicyStats[] BotPolicyStatistics { get; set; }
    }
}