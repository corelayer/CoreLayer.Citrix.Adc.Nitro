using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotPolicyLabel
{
    public class BotPolicyLabelStatResponse : NitroResponse
    {
        [JsonPropertyName("botpolicylabel")]public BotPolicyLabelStats[] BotPolicyLabelStatistics { get; set; }
    }
}