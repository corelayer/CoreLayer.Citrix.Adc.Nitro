using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Responder.ResponderPolicy
{
    public class ResponderPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/responderpolicy";
        public override INitroRequestOptions Options { get; set; } = new ResponderPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ResponderPolicyStatRequestDataRoot();
        
        public ResponderPolicyStatRequestConfiguration() {}
    }
}