using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/dnstxtrec";
        public override INitroRequestOptions Options { get; set; } = new DnsTxtRecRemoveRequestOptions();
        public override INitroRequestDataRoot DataRoot  => new DnsTxtRecRemoveRequestDataRoot(); 
    }
}