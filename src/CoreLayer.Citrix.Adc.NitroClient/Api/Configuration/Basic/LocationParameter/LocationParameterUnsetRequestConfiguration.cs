using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUnsetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/locationparameter";
        public override INitroRequestDataRoot DataRoot { get; } 
        public override INitroRequestOptions Options => new LocationParameterUnsetRequestOptions(){Action = "unset"};
        
        public LocationParameterUnsetRequestConfiguration(LocationParameterUnsetRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}