using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequestDataRoot : INitroRequestDataRoot
    {
        public dynamic[] SystemBackup { get; }


        public SystemBackupCreateRequestDataRoot() {}

        public SystemBackupCreateRequestDataRoot(dynamic data)
        {
            SystemBackup = new[] {data};
        }
        public SystemBackupCreateRequestDataRoot(dynamic[] data)
        {
            SystemBackup = data;
        }
    }
}