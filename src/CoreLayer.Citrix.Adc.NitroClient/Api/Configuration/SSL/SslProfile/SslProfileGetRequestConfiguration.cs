using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile
{
    public class SslProfileGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/sslprofile";
        public override INitroRequestDataRoot DataRoot => new SslProfileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SslProfileGetRequestOptions();
    }
}