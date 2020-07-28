using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicyLabel;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.AppFirewall.AppFwPolicyLabel
{
    public class AppFwPolicyLabelStatCommand : NitroCommand<AppFwPolicyLabelStatResponse>
    {
        public AppFwPolicyLabelStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}