using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.InatSession
{
    public class InatSessionStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/inatsession";
        public override INitroRequestOptions Options { get; set; } = new InatSessionStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new InatSessionStatRequestDataRoot();
        
        public InatSessionStatRequestConfiguration() {}
    }
}