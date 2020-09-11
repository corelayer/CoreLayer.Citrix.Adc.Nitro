using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location
{
    public class LocationRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/location";
        public override INitroRequestDataRoot DataRoot => new LocationRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LocationRemoveRequestOptions();
    }
}