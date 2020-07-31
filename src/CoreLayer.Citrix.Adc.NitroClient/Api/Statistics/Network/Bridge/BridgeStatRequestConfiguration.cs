using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Bridge
{
    public class BridgeStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/bridge";
        public override INitroRequestOptions Options { get; set; } = new BridgeStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new BridgeStatRequestDataRoot();
        
        public BridgeStatRequestConfiguration() {}
    }
}