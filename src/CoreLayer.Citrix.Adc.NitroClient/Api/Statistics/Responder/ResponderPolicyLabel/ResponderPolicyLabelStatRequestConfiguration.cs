using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Responder.ResponderPolicyLabel
{
    public class ResponderPolicyLabelStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/responderpolicylabel";
        public override INitroRequestOptions Options { get; set; } = new ResponderPolicyLabelStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ResponderPolicyLabelStatRequestDataRoot();
        
        public ResponderPolicyLabelStatRequestConfiguration() {}
    }
}