using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.VpnVserver
{
    public class VpnVserverStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/vpnvserver";
        public override INitroRequestOptions Options { get; set; } = new VpnVserverStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new VpnVserverStatRequestDataRoot();
                        
        public VpnVserverStatRequestConfiguration() {}
    }
}