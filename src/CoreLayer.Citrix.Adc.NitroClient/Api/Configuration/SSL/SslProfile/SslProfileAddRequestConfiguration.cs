using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile
{
    public class SslProfileAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/sslprofile";
        public override INitroRequestOptions Options => new SslProfileAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public SslProfileAddRequestConfiguration(SslProfileAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}