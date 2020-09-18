using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/cspolicylabel";
        public override INitroRequestDataRoot DataRoot => new CsPolicyLabelRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsPolicyLabelRemoveRequestOptions();
    }
}