using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Vlan
{
    public class VlanStatRequestConfiguration : NitroRequestConfiguration
    {
         public override HttpMethod Method => HttpMethod.Get;
         public override string ResourcePath => "/nitro/v1/stat/vlan";
         public override INitroRequestOptions Options { get; set; } = new VlanStatRequestOptions();
         public override INitroRequestDataRoot DataRoot => new VlanStatRequestDataRoot();
                
         public VlanStatRequestConfiguration() {}
    }
}