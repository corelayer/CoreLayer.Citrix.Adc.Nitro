using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertKey
{
    public class SslCertKeyAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/sslcertkey";
        public override INitroRequestOptions Options => new SslCertKeyAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public SslCertKeyAddRequestConfiguration(SslCertKeyAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}