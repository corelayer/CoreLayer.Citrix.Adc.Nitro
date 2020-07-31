using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Authentication.AuthenticationPolicy
{
    public class AuthenticationPolicyStatCommand : NitroCommand<AuthenticationPolicyStatResponse>
    {
        public AuthenticationPolicyStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}