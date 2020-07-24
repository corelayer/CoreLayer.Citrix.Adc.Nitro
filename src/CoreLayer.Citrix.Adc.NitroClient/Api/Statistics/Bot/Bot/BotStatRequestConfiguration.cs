using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.Bot
{
    public class BotStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/bot";
        public override INitroRequestOptions Options { get; set; } = new BotStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new BotStatRequestDataRoot();
                
        public BotStatRequestConfiguration() {}
    }
}