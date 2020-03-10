using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systembackup";
        public override INitroRequestOptions Options { get; set; } = new SystemBackupCreateRequestOptions { Action =  "create"};
        public override INitroRequestDataRoot DataRoot { get; } = new SystemBackupCreateRequestDataRoot();

        public SystemBackupCreateRequestConfiguration() {}

        public SystemBackupCreateRequestConfiguration(ISystemBackupCreateRequestData data)
        {
            DataRoot = new SystemBackupCreateRequestDataRoot(data);
        }

        public SystemBackupCreateRequestConfiguration(INitroRequestDataRoot data)
        {
            DataRoot = data;
        }
    }
}