using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/radiusnode";
        public override INitroRequestDataRoot DataRoot { get; } 
        public override INitroRequestOptions Options => new RadiusNodeUpdateRequestOptions();
        
        public RadiusNodeUpdateRequestConfiguration(RadiusNodeUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}