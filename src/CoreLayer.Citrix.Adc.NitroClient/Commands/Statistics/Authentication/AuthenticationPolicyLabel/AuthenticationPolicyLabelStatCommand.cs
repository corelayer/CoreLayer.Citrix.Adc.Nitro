using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationPolicyLabel;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Authentication.AuthenticationPolicyLabel
{
    public class AuthenticationPolicyLabelStatCommand : NitroCommand<AuthenticationPolicyLabelStatResponse>
    {
        public AuthenticationPolicyLabelStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}