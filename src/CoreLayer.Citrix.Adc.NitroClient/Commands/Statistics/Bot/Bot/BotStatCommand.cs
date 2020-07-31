using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.Bot;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Bot.Bot
{
    public class BotStatCommand : NitroCommand<BotStatResponse>
    {
        public BotStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}