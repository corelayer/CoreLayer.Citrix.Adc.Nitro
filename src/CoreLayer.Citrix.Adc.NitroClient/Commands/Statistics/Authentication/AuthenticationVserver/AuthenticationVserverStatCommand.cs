using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationVserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Authentication.AuthenticationVserver
{
    public class AuthenticationVserverStatCommand : NitroCommand<AuthenticationVserverStatResponse>
    {
        public AuthenticationVserverStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}