using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.AppFirewall.AppFwPolicy
{
    public class AppFwPolicyStatCommand : NitroCommand<AppFwPolicyStatResponse>
    {
        public AppFwPolicyStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}