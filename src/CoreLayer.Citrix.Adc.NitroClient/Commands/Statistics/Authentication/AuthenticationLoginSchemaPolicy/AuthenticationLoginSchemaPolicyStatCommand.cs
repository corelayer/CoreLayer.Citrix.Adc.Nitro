using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationLoginSchemaPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Authentication.AuthenticationLoginSchemaPolicy
{
    public class AuthenticationLoginSchemaPolicyStatCommand : NitroCommand<AuthenticationLoginSchemaPolicyStatResponse>
    {
        public AuthenticationLoginSchemaPolicyStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}