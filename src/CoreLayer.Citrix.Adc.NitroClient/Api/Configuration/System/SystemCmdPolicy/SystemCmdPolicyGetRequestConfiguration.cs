using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public override INitroRequestOptions Options { get; set; } = new SystemCmdPolicyGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemCmdPolicyGetRequestDataRoot();

        public SystemCmdPolicyGetRequestConfiguration() {}
    }
}