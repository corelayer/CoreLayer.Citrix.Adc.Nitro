using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationSamlIdPPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Authentication.AuthenticationSamlIdPPolicy
{
    public class AuthenticationSamlIdPPolicyStatCommand : NitroCommand<AuthenticationSamlIdPPolicyStatResponse>
    {
        public AuthenticationSamlIdPPolicyStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}