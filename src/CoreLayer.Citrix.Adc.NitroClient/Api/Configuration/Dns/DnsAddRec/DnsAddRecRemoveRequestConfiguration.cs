using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/dnsaddrec";
        public override INitroRequestOptions Options { get; set; } = new DnsAddRecRemoveRequestOptions();
        public override INitroRequestDataRoot DataRoot  => new DnsAddRecRemoveRequestDataRoot(); 
    }
}