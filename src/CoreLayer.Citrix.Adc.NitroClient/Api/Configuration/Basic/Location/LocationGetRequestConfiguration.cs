using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location
{
    public class LocationGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/location";
        public override INitroRequestDataRoot DataRoot => new LocationGetRequestDataRoot(); 
        public override INitroRequestOptions Options { get; set; } = new LocationGetRequestOptions();
                
        public LocationGetRequestConfiguration()
        {
            
        }
    }
}