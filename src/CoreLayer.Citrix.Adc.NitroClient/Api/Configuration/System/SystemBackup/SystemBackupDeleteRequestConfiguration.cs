using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options { get; set; } = new SystemBackupDeleteRequestOptions(null);
        public override INitroRequestDataRoot DataRoot  => new SystemBackupDeleteRequestDataRoot();

        public SystemBackupDeleteRequestConfiguration() {}
    }
}