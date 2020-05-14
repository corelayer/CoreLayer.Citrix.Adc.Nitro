using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUser
{
    public class SystemUserGetCommand : NitroCommand<SystemUserGetResponse>
    {
        public SystemUserGetCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) : base(
            client, requestConfiguration)
        {
            
        }
    }
}