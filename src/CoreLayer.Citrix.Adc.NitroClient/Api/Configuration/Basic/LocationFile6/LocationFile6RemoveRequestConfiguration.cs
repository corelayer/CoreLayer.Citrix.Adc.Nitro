using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6RemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/locationfile6";
        public override INitroRequestDataRoot DataRoot => new LocationFile6RemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LocationFile6RemoveRequestOptions();
    }
}