using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUser
{
    public class SystemUserRemoveCommand : NitroCommand<NitroResponse>
    {
        public SystemUserRemoveCommand(INitroHttpClient client, INitroRequestConfiguration requestConfiguration) : base(
            client, requestConfiguration)
        {
            
        }
    }
}