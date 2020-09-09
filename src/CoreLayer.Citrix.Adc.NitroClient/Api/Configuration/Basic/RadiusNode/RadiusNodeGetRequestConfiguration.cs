using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/radiusnode";
        public override INitroRequestDataRoot DataRoot => new RadiusNodeGetRequestDataRoot(); 
        public override INitroRequestOptions Options { get; set; } = new RadiusNodeGetRequestOptions();
                
        public RadiusNodeGetRequestConfiguration()
        {
            
        }
    }
}