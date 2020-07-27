using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotProfile
{
    public class BotProfileStatResponse : NitroResponse
    {
        [JsonPropertyName("botprofile")]public BotProfileStats[] BotProfileStatistics { get; set; }
    }
}