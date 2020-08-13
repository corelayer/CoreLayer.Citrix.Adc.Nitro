using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPbr
{
    public class NsPbrStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nspbr";
        public override INitroRequestOptions Options { get; set; } = new NsPbrStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsPbrStatRequestDataRoot();
                        
        public NsPbrStatRequestConfiguration() {}
    }
}