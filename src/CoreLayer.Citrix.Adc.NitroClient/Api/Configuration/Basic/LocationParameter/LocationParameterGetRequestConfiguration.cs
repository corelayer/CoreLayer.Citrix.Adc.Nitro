using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/locationparameter";
        public override INitroRequestDataRoot DataRoot => new LocationParameterGetRequestDataRoot(); 
        public override INitroRequestOptions Options { get; set; } = new LocationParameterGetRequestOptions();
                
        public LocationParameterGetRequestConfiguration()
        {
            
        }
    }
}