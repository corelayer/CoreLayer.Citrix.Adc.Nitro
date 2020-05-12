using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupCreateCommand : NitroCommand<SystemBackupCreateResponse>
    {
        public SystemBackupCreateCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}