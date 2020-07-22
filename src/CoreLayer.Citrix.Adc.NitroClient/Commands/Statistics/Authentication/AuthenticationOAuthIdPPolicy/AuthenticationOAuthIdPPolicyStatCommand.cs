using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationOAuthIdPPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Authentication.AuthenticationOAuthIdPPolicy
{
    public class AuthenticationOAuthIdPPolicyStatCommand : NitroCommand<AuthenticationOAuthIdPPolicyStatResponse>
    {
        public AuthenticationOAuthIdPPolicyStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}