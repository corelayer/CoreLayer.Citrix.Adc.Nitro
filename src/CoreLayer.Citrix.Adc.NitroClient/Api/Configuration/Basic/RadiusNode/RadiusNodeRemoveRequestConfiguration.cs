using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/radiusnode";
        public override INitroRequestDataRoot DataRoot => new RadiusNodeRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new RadiusNodeRemoveRequestOptions();
    }
}