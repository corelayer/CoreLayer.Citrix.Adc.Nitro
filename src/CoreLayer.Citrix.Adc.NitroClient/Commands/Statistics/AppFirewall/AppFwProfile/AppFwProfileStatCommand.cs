using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.AppFirewall.AppFwProfile
{
    public class AppFwProfileStatCommand : NitroCommand<AppFwProfileStatResponse>
    {
        public AppFwProfileStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}