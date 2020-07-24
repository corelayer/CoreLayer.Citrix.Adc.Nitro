using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Bot.BotPolicy
{
    public class BotPolicyStatCommand : NitroCommand<BotPolicyStatResponse>
    {
        public BotPolicyStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}