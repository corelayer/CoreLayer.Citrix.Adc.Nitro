using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMap
{
    public class PolicyStringMapGetRequestConfiguration :NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/policystringmap";
        public override INitroRequestOptions Options { get; set; } = new PolicyStringMapGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new PolicyStringMapGetRequestDataRoot();
    }
}