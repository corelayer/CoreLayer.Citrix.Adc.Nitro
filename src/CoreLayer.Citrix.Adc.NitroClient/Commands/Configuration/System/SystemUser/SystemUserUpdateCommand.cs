using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUser
{
    public class SystemUserUpdateCommand : NitroCommand<SystemUserUpdateResponse>
    {
        public SystemUserUpdateCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) : base(
            client, requestConfiguration)
        {
            
        }
    }
}