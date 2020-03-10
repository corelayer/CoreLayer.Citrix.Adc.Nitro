using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options { get; set; } = new SystemBackupGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemBackupGetRequestDataRoot();

        public SystemBackupGetRequestConfiguration() {}
    }
}