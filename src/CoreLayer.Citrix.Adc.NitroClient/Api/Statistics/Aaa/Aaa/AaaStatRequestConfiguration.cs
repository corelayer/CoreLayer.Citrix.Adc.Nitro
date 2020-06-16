using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Aaa.Aaa
{
    public class AaaStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/aaa";
        public override INitroRequestOptions Options { get; set; } = new AaaStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AaaStatRequestDataRoot();
        
        public AaaStatRequestConfiguration() {}
    }
}