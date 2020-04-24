using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemuser_systemcmdpolicy_binding";
        public override INitroRequestOptions Options => new SystemUserSystemCmdPolicyBindingAddRequestOptions(); 
        public override INitroRequestDataRoot DataRoot { get; }

        public SystemUserSystemCmdPolicyBindingAddRequestConfiguration(INitroRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}