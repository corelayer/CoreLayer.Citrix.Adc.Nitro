using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ssl.SslvServer
{
    public class SslvServerStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/sslvserver";
        public override INitroRequestOptions Options { get; set; } = new SslvServerStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SslvServerStatRequestDataRoot();
        
        public SslvServerStatRequestConfiguration() {}
    }
}