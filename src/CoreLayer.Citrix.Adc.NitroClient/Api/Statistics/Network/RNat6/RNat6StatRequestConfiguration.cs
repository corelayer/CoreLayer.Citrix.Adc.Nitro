using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNat6
{
    public class RNat6StatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/rnat6";
        public override INitroRequestOptions Options { get; set; } = new RNat6StatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new RNat6StatRequestDataRoot();
        
        public RNat6StatRequestConfiguration() {}
    }
}