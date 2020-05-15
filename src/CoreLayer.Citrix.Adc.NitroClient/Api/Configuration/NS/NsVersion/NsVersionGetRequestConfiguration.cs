using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsVersion
{
    public class NsVersionGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/nsversion";
        public override INitroRequestDataRoot DataRoot => new NsVersionGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NsVersionGetRequestOptions();
    }
}