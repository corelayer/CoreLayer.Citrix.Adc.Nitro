using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemCpu
{
    public class SystemCpuStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/systemcpu";
        public override INitroRequestOptions Options { get; set; } = new SystemCpuStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemCpuStatRequestDataRoot();
        
        public SystemCpuStatRequestConfiguration() {}
    }
}