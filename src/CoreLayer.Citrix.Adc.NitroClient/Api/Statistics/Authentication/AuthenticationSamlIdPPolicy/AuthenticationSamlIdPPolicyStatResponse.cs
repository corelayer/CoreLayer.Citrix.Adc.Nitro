using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationSamlIdPPolicy
{
    public class AuthenticationSamlIdPPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("authenticationsamlidppolicy")]public AuthenticationSamlIdPPolicyStats AuthenticationSamlIdPPolicyStatistics
        {
            get;
            set;
        }
    }
}