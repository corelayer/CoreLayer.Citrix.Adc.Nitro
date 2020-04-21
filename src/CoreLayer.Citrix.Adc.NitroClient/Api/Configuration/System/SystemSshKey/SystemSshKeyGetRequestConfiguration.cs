using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey
{
    public class SystemSshKeyGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemsshkey";
        public override INitroRequestDataRoot DataRoot => new SystemSshKeyGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemSshKeyGetRequestOptions();
    }
}