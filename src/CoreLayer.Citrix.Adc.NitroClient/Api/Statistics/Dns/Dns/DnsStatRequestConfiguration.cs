using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.Dns
{
    public class DnsStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/dns";
        public override INitroRequestOptions Options { get; set; } = new DnsStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new DnsStatRequestDataRoot();
                        
        public DnsStatRequestConfiguration() {}
    }
}