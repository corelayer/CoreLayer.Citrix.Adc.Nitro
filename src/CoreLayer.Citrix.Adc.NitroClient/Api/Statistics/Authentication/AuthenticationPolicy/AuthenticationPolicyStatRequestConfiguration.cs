using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationPolicy
{
    public class AuthenticationPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/authenticationpolicy";
        public override INitroRequestOptions Options { get; set; } = new AuthenticationPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AuthenticationPolicyStatRequestDataRoot();
        
        public AuthenticationPolicyStatRequestConfiguration() {}
    }
}