using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.VpnUrlPolicy
{
    public class VpnUrlPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
         public override HttpMethod Method => HttpMethod.Get;
         public override string ResourcePath => "/nitro/v1/stat/vpnurlpolicy";
         public override INitroRequestOptions Options { get; set; } = new VpnUrlPolicyStatRequestOptions();
         public override INitroRequestDataRoot DataRoot => new VpnUrlPolicyStatRequestDataRoot();
                        
         public VpnUrlPolicyStatRequestConfiguration() {}
    }
}