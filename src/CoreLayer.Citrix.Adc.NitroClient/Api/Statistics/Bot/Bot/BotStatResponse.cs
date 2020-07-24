using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.Bot
{
    public class BotStatResponse : NitroResponse
    {
        [JsonPropertyName("bot")]public BotStats BotStatistics { get; set; }
    }
}