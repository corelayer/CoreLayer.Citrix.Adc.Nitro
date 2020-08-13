using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Vxlan
{
    public class VxlanStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/vxlan";
        public override INitroRequestOptions Options { get; set; } = new VxlanStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new VxlanStatRequestDataRoot();
                
        public VxlanStatRequestConfiguration() {}
    }
}