using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/dnscnamerec";
        public override INitroRequestOptions Options => new DnsCNameRecAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public DnsCNameRecAddRequestConfiguration(DnsCNameRecAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}