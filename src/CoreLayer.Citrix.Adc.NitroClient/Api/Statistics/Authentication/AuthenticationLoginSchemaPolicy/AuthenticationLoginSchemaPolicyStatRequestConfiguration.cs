using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationLoginSchemaPolicy
{
    public class AuthenticationLoginSchemaPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/authenticationloginschemapolicy";
        public override INitroRequestOptions Options { get; set; } = new AuthenticationLoginSchemaPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AuthenticationLoginSchemaPolicyStatRequestDataRoot();
        
        public AuthenticationLoginSchemaPolicyStatRequestConfiguration() {}
    }
}