﻿using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingRemoveCommand : NitroCommand<NitroResponse>
    {
        public SystemUserSystemCmdPolicyBindingRemoveCommand(INitroHttpClient client,
            INitroRequestConfiguration requestConfiguration) : base(client, requestConfiguration)
        {
            
        }
    }
}