using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Authentication;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationLoginSchemaPolicy
{
    public class AuthenticationLoginSchemaPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("authenticationloginschemapolicy")]public AuthenticationLoginSchemaPolicyStats[] AuthenticationLoginSchemaPolicyStatistics
        {
            get;
            set;
        }
    }
}