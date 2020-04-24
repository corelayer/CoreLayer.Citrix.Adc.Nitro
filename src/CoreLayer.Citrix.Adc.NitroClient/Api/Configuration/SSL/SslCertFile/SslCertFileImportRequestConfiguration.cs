using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileImportRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/sslcertfile";
        public override INitroRequestOptions Options => new SslCertFileImportRequestOptions(){ Action = "Import"};
        public override INitroRequestDataRoot DataRoot { get; }

        public SslCertFileImportRequestConfiguration(SslCertFileImportRequestDataRoot dataroot)
        {
            DataRoot = dataroot;
        }
    }
}