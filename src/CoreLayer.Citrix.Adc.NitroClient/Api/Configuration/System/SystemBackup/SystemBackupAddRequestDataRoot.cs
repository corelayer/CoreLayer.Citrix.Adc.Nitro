using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemBackupAddRequestDataRoot(dynamic data)
        {
            SystemBackup = new dynamic[] {data};
        }
        public SystemBackupAddRequestDataRoot(dynamic[] data)
        {
            SystemBackup = data;
        }
        public dynamic[] SystemBackup { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in SystemBackup)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}