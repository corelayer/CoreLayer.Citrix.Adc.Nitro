using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/dnstxtrec";
        public override INitroRequestOptions Options => new DnsTxtRecAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public DnsTxtRecAddRequestConfiguration(DnsTxtRecAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}