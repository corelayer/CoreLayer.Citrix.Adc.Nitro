using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationSamlIdPPolicy
{
    public class AuthenticationSamlIdPPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/authenticationsamlidppolicy";
        public override INitroRequestOptions Options { get; set; } = new AuthenticationSamlIdPPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AuthenticationSamlIdPPolicyStatRequestDataRoot();
        
        public AuthenticationSamlIdPPolicyStatRequestConfiguration() {}
    }
}