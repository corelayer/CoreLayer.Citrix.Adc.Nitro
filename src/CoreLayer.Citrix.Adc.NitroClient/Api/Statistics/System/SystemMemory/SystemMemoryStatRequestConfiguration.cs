using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemMemory
{
    public class SystemMemoryStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/systemmemory";
        public override INitroRequestOptions Options { get; set; } = new SystemMemoryStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemMemoryStatRequestDataRoot();
        
        public SystemMemoryStatRequestConfiguration() {}
    }
}