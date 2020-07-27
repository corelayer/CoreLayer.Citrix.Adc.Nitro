using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotProfile
{
    public class BotProfileStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/botprofile";
        public override INitroRequestOptions Options { get; set; } = new BotProfileStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new BotProfileStatRequestDataRoot();
                
        public BotProfileStatRequestConfiguration() {}
    }
}