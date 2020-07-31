using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Bot.BotProfile
{
    public class BotProfileStatCommand : NitroCommand<BotProfileStatResponse>
    {
        public BotProfileStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}