using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options => new SystemBackupAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public SystemBackupAddRequestConfiguration(SystemBackupAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}