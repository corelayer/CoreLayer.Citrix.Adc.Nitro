using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.TunnelIp
{
    public class TunnelIpStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/tunnelip";
        public override INitroRequestOptions Options { get; set; } = new TunnelIpStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new TunnelIpStatRequestDataRoot();
        
        public TunnelIpStatRequestConfiguration() {}
    }
}