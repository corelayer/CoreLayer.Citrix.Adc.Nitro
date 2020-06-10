using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ha.HaNode
{
    public class HaNodeStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/hanode";
        public override INitroRequestDataRoot DataRoot => new HaNodeStatRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new HaNodeStatRequestOptions();
    }
}