using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location
{
    public class LocationAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/location";
        public override INitroRequestDataRoot DataRoot { get; } 
        public override INitroRequestOptions Options => new LocationAddRequestOptions();
        
        public LocationAddRequestConfiguration(LocationAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}