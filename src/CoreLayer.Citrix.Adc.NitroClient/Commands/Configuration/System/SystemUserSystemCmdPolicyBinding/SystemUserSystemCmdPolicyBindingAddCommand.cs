﻿using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddCommand : NitroCommand<NitroResponse>
    {
        public SystemUserSystemCmdPolicyBindingAddCommand(INitroHttpClient client,
            INitroRequestConfiguration requestConfiguration) : base(client, requestConfiguration)
        {
            
        }
    }
}