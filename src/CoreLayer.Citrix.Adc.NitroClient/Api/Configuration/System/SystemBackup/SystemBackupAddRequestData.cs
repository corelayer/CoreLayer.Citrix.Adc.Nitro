using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequestData : INitroRequestData
    {
        public string FileName { get; }

        public SystemBackupAddRequestData(string fileName)
        {
            FileName = fileName;
        }
    }
}