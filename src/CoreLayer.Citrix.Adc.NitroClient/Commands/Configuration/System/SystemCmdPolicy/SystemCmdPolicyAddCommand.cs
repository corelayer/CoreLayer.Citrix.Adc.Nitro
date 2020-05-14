using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddCommand : NitroCommand<SystemCmdPolicyAddResponse>
    {
        public SystemCmdPolicyAddCommand(NitroServiceClient client, NitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}