using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationVserver
{
    public class AuthenticationVserverStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/authenticationvserver";
        public override INitroRequestOptions Options { get; set; } = new AuthenticationVserverStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AuthenticationVserverStatRequestDataRoot();
                
        public AuthenticationVserverStatRequestConfiguration() {}
    }
}