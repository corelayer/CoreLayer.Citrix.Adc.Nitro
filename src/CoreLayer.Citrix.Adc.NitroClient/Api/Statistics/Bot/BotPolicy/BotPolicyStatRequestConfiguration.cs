using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotPolicy
{
    public class BotPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/botpolicy";
        public override INitroRequestOptions Options { get; set; } = new BotPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new BotPolicyStatRequestDataRoot();
                
        public BotPolicyStatRequestConfiguration() {}
    }
}