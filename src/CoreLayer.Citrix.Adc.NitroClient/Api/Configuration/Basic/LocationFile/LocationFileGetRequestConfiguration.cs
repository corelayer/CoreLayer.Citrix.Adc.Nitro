using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/locationfile";
        public override INitroRequestDataRoot DataRoot => new LocationFileGetRequestDataRoot(); 
        public override INitroRequestOptions Options { get; set; } = new LocationFileGetRequestOptions();
                
        public LocationFileGetRequestConfiguration()
        {
            
        }
    }
}