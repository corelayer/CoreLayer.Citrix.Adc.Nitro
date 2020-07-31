using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationPolicyLabel
{
    public class AuthenticationPolicyLabelStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/authenticationpolicylabel";
        public override INitroRequestOptions Options { get; set; } = new AuthenticationPolicyLabelStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AuthenticationPolicyLabelStatRequestDataRoot();
        
        public AuthenticationPolicyLabelStatRequestConfiguration() {}
    }
}