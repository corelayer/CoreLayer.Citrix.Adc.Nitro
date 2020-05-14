using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddCommand : NitroCommand<SystemUserSystemCmdPolicyBindingAddResponse>
    {
        public SystemUserSystemCmdPolicyBindingAddCommand(INitroServiceClient client,
            INitroRequestConfiguration requestConfiguration) : base(client, requestConfiguration)
        {
            
        }
    }
}