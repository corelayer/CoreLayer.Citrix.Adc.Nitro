using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public override INitroRequestOptions Options => new SystemCmdPolicyAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public SystemCmdPolicyAddRequestConfiguration(SystemCmdPolicyAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}