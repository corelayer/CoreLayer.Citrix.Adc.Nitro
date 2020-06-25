using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsNsRec
{
    public class DnsNsRecAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/dnsnsrec";
        public override INitroRequestOptions Options => new DnsNsRecAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public DnsNsRecAddRequestConfiguration(DnsNsRecAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}