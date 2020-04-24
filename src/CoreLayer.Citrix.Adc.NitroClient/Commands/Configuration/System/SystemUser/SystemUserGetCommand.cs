﻿using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUser
{
    public class SystemUserGetCommand : NitroCommand<SystemUserGetReponse>
    {
        public SystemUserGetCommand(INitroHttpClient client, INitroRequestConfiguration requestConfiguration) : base(
            client, requestConfiguration)
        {
            
        }
    }
}