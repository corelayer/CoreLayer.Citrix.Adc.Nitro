using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationOAuthIdPPolicy
{
    public class AuthenticationOAuthIdPPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/authenticationoauthidppolicy";
        public override INitroRequestOptions Options { get; set; } = new AuthenticationOAuthIdPPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AuthenticationOAuthIdPPolicyStatRequestDataRoot();
        
        public AuthenticationOAuthIdPPolicyStatRequestConfiguration() {}
    }
}