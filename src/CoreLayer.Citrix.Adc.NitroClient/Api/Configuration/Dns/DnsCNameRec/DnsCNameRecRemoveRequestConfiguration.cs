using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/dnscnamerec";
        public override INitroRequestOptions Options { get; set; } = new DnsCNameRecRemoveRequestOptions();
        public override INitroRequestDataRoot DataRoot  => new DnsCNameRecRemoveRequestDataRoot(); 
    }
}