using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationData
{
    public class LocationDataClearRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/locationdata";
        public override INitroRequestDataRoot DataRoot => new LocationDataClearRequestDataRoot(); 
        public override INitroRequestOptions Options  => new LocationDataClearRequestOptions(){Action = "clear"};
                
        public LocationDataClearRequestConfiguration()
        {
            
        }
    }
}