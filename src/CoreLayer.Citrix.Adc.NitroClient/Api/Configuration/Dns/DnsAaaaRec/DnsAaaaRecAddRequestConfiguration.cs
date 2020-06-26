using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/dnsaaaarec";
        public override INitroRequestOptions Options => new DnsAaaaRecAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public DnsAaaaRecAddRequestConfiguration(DnsAaaaRecAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}