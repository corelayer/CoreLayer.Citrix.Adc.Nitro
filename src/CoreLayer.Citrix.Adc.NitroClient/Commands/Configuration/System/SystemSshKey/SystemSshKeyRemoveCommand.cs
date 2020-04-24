using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemSshKey
{
    public class SystemSshKeyRemoveCommand : NitroCommand<NitroResponse>
    {
        public SystemSshKeyRemoveCommand(INitroServiceClient client, INitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}