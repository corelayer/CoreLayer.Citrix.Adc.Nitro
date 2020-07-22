using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationVserver
{
    public class AuthenticationVserverStatResponse : NitroResponse
    {
        [JsonPropertyName("authenticationvserver")]public AuthenticationVserverStats[] AuthenticationVserverStatistics
        {
            get;
            set;
        }
    }
}