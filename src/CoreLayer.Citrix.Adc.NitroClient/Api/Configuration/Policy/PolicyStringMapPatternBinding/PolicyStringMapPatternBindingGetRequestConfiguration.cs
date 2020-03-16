using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapPatternBinding
{
    public class PolicyStringMapPatternBindingGetRequestConfiguration : NitroRequestConfiguration
    {
                public override HttpMethod Method => HttpMethod.Get;
                public override string ResourcePath => "/nitro/v1/config/policystringmap_pattern_binding";
                public override INitroRequestOptions Options { get; set; } = new PolicyStringMapPatternBindingGetRequestOptions();
                public override INitroRequestDataRoot DataRoot => new PolicyStringMapPatternBindingGetRequestDataRoot();
    }
}