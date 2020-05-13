using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingRemoveCommand : NitroCommand<SystemUserSystemCmdPolicyBindingRemoveResponse>
    {
        public SystemUserSystemCmdPolicyBindingRemoveCommand(INitroServiceClient client,
            INitroRequestConfiguration requestConfiguration) : base(client, requestConfiguration)
        {
            
        }
    }
}