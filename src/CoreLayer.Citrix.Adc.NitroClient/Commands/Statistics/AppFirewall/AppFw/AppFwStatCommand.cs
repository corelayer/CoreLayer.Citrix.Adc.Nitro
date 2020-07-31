using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFw;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.AppFirewall.AppFw
{
    public class AppFwStatCommand : NitroCommand<AppFwStatResponse>
    {
        public AppFwStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}