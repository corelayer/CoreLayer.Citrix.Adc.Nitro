using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNat
{
    public class RNatStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/rnat";
        public override INitroRequestOptions Options { get; set; } = new RNatStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new RNatStatRequestDataRoot();
        
        public RNatStatRequestConfiguration() {}
    }
}