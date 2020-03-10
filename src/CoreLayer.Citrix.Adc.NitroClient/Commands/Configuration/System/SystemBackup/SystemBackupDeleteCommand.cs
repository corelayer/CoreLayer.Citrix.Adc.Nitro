using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteCommand : NitroCommand
    {
        public SystemBackupDeleteCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration) { }
    }
}