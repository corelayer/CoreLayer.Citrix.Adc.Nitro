using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey
{
    public class SystemSshKeyImportRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemsshkey";
        public override INitroRequestOptions Options => new SystemSshKeyImportRequestOptions(){Action = "Import"};
        public override INitroRequestDataRoot DataRoot { get; }

        public SystemSshKeyImportRequestConfiguration(INitroRequestDataRoot dataroot)
        {
            DataRoot = dataroot;
        }
    }
}