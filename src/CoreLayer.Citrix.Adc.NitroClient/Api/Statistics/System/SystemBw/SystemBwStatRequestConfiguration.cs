using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemBw
{
    public class SystemBwStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/systembw";
        public override INitroRequestOptions Options { get; set; } = new SystemBwStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new SystemBwStatRequestDataRoot();
        
        public SystemBwStatRequestConfiguration() {}
    }
}