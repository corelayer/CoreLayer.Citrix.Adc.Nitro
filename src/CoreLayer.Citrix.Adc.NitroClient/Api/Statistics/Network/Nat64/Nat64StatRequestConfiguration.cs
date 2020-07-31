using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Nat64
{
    public class Nat64StatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nat64";
        public override INitroRequestOptions Options { get; set; } = new Nat64StatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new Nat64StatRequestDataRoot();
        
        public Nat64StatRequestConfiguration() {}
    }
}