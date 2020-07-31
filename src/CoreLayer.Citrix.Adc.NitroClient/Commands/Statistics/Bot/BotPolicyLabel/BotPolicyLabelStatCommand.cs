using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotPolicyLabel;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Bot.BotPolicyLabel
{
    public class BotPolicyLabelStatCommand : NitroCommand<BotPolicyLabelStatResponse>
    {
        public BotPolicyLabelStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}