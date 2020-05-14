

using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetCommand : NitroCommand<SystemCmdPolicyGetResponse>
    {
        public SystemCmdPolicyGetCommand(NitroServiceClient client, NitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}