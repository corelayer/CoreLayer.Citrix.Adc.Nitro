using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsMemory
{
    public class NsMemoryStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nsmemory";
        public override INitroRequestOptions Options { get; set; } = new NsMemoryStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsMemoryStatRequestDataRoot();
                        
        public NsMemoryStatRequestConfiguration() {}
    }
}