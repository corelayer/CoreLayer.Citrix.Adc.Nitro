using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6AddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/locationfile6";
        public override INitroRequestDataRoot DataRoot { get; } 
        public override INitroRequestOptions Options => new LocationFile6AddRequestOptions();
        
        public LocationFile6AddRequestConfiguration(LocationFile6AddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}