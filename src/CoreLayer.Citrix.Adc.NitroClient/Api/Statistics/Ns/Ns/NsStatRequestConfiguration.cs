using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.Ns
{
    public class NsStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/ns";
        public override INitroRequestOptions Options { get; set; } = new NsStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsStatRequestDataRoot();
        
        public NsStatRequestConfiguration() {}
    }
}