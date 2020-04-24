using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/systemuser_systemcmdpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new SystemUserSystemCmdPolicyBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemUserSystemCmdPolicyBindingRemoveRequestOptions();
    }
}