using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPbr6
{
    public class NsPbr6StatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nspbr6";
        public override INitroRequestOptions Options { get; set; } = new NsPbr6StatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsPbr6StatRequestDataRoot();
                        
        public NsPbr6StatRequestConfiguration() {}
    }
}