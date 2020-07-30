using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Inat
{
    public class InatStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/inat";
        public override INitroRequestOptions Options { get; set; } = new InatStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new InatStatRequestDataRoot();
        
        public InatStatRequestConfiguration() {}
    }
}