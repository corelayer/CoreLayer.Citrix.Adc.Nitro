using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ssl.Ssl
{
    public class SslStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/ssl";
        public override INitroRequestOptions Options { get; set; } = new SslStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SslStatRequestDataRoot();
        
        public SslStatRequestConfiguration() {}
    }
}