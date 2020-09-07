using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/locationfile";
        public override INitroRequestDataRoot DataRoot => new LocationFileRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LocationFileRemoveRequestOptions();
    }
}