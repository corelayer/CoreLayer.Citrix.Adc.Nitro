using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationPolicyLabel
{
    public class AuthenticationPolicyLabelStatResponse : NitroResponse
    {
        [JsonPropertyName("authenticationpolicylabel")]public AuthenticationPolicyLabelStats[] AuthenticationPolicyLabelStatistics
        {
            get;
            set;
        }
    }
}