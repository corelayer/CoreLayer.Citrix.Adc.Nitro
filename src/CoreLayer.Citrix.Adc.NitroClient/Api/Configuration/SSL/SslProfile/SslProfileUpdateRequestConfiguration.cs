using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile
{
    public class SslProfileUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/sslprofile";
        public override INitroRequestOptions Options => new SslProfileUpdateRequestOption();
        public override INitroRequestDataRoot DataRoot { get; }

        public SslProfileUpdateRequestConfiguration(SslProfileUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}