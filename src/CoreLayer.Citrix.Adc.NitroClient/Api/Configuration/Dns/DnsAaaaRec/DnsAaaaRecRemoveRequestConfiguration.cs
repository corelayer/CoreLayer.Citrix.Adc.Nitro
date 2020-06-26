using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/dnsaaaarec";
        public override INitroRequestOptions Options { get; set; } = new DnsAaaaRecRemoveRequestOptions();
        public override INitroRequestDataRoot DataRoot  => new DnsAaaaRecRemoveRequestDataRoot(); 
    }
}