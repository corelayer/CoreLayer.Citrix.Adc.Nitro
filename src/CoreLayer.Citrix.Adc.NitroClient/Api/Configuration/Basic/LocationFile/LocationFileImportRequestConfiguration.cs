using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileImportRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/locationfile";
        public override INitroRequestDataRoot DataRoot { get; } 
        public override INitroRequestOptions Options => new LocationFileImportRequestOptions(){Action = "Import"};
        
        public LocationFileImportRequestConfiguration(LocationFileImportRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}