using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/dnsaddrec";
        public override INitroRequestOptions Options => new DnsAddRecAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public DnsAddRecAddRequestConfiguration(DnsAddRecAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}