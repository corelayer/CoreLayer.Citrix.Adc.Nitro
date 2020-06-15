using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.System
{
    public class SystemStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/system";
        public override INitroRequestOptions Options { get; set; } = new SystemStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemStatRequestDataRoot();
        
        public SystemStatRequestConfiguration() {}
    }
}