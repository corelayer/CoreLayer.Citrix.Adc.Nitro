using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/policystringmap_pattern_binding";
        public override INitroRequestOptions Options => new PolicyStringMapBindingRemoveRequestOptions();
        public override INitroRequestDataRoot DataRoot => new PolicyStringMapBindingRemoveRequestDataRoot();
    }
}