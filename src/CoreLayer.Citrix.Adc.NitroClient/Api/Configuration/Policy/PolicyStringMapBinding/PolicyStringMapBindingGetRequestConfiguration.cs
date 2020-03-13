using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingGetRequestConfiguration : NitroRequestConfiguration
    {        
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/policystringmap_binding";
        public override INitroRequestOptions Options { get; set; } = new PolicyStringMapBindingGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new PolicyStringMapBindingGetRequestDataRoot();
        
    }
}