using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotPolicyLabel
{
    public class BotPolicyLabelStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/botpolicylabel";
        public override INitroRequestOptions Options { get; set; } = new BotPolicyLabelStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new BotPolicyLabelStatRequestDataRoot();
                
        public BotPolicyLabelStatRequestConfiguration() {}
    }
}