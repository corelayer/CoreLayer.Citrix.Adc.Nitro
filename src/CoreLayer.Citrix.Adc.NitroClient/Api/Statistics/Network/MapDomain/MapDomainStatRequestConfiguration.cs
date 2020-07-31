using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.MapDomain
{
    public class MapDomainStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/mapdomain";
        public override INitroRequestOptions Options { get; set; } = new MapDomainStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new MapDomainStatRequestDataRoot();
        
        public MapDomainStatRequestConfiguration() {}
    }
}