using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationOAuthIdPPolicy
{
    public class AuthenticationOAuthIdPPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("authenticationoauthidppolicy")]public AuthenticationOAuthIdPPolicyStats AuthenticationOAuthIdPPolicyStatistics
        {
            get;
            set;
        }
    }
}