using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupAddCommand : NitroCommand<SystemBackupAddResponse>
    {
        public SystemBackupAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}