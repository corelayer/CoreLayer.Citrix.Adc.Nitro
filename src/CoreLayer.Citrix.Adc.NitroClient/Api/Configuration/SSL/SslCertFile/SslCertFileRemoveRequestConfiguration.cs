using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/sslcertfile";
        public override INitroRequestDataRoot DataRoot => new SslCertFileRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SslCertFileRemoveRequestOptions();
    }
}