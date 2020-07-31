using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.TunnelIp6
{
    public class TunnelIp6StatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/tunnelip6";
        public override INitroRequestOptions Options { get; set; } = new TunnelIp6StatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new TunnelIp6StatRequestDataRoot();
                
        public TunnelIp6StatRequestConfiguration() {}
    }
}