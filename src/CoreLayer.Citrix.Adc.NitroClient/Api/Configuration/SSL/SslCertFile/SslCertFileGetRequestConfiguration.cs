using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/sslcertfile";
        public override INitroRequestDataRoot DataRoot => new SslCertFileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SslCertFileGetRequestOptions();
    }
}