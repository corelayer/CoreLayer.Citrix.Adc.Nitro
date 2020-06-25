using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsNsRec
{
    public class DnsNsRecRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/dnsnsrec";
        public override INitroRequestOptions Options { get; set; } = new DnsNsRecRemoveRequestOptions();
        public override INitroRequestDataRoot DataRoot  => new DnsNsRecRemoveRequestDataRoot(); 
    }
}