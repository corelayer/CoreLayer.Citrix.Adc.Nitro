using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNatIp
{
    public class RNatIpStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/rnatip";
        public override INitroRequestOptions Options { get; set; } = new RNatIpStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new RNatIpStatRequestDataRoot();
        
        public RNatIpStatRequestConfiguration() {}
    }
}