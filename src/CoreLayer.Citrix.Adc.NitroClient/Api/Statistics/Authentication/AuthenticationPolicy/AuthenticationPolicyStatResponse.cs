using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationPolicy
{
    public class AuthenticationPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("authenticationpolicy")]public AuthenticationPolicyStats AuthenticationPolicyStatistics
        {
            get;
            set;
        } 
    }
}