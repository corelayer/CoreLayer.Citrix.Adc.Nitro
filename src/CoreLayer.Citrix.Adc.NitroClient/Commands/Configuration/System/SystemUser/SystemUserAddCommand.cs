using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemUser
{
    public class SystemUserAddCommand : NitroCommand<NitroResponse>
    {
        public SystemUserAddCommand(INitroHttpClient client, INitroRequestConfiguration requestConfiguration) : base(
            client, requestConfiguration)
        {
            
        }
    }
}