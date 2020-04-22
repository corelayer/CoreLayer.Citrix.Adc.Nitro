using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemSshKey
{
    public class SystemSshKeyImportCommand : NitroCommand<NitroResponse>
    {
        public SystemSshKeyImportCommand(INitroHttpClient client, INitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}