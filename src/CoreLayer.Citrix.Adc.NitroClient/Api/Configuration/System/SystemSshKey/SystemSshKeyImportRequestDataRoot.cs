using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey
{
    public class SystemSshKeyImportRequestDataRoot : INitroRequestDataRoot
    {
        public SystemSshKeyImportRequestDataRoot(dynamic data)
        {
            SystemSshKey = new dynamic[] {data};
        }
        public SystemSshKeyImportRequestDataRoot(dynamic[] data)
        {
            SystemSshKey = data;
        }
        public dynamic[] SystemSshKey { get; set; }
    }
}