using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.Vpn
{
    public class VpnStatRequestConfiguration : NitroRequestConfiguration
    {
         public override HttpMethod Method => HttpMethod.Get;
         public override string ResourcePath => "/nitro/v1/stat/vpn";
         public override INitroRequestOptions Options { get; set; } = new VpnStatRequestOptions();
         public override INitroRequestDataRoot DataRoot => new VpnStatRequestDataRoot();
                
         public VpnStatRequestConfiguration() {}
    }
}