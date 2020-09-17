using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/cspolicylabel";
        public override INitroRequestOptions Options => new CsPolicyLabelAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsPolicyLabelAddRequestConfiguration(CsPolicyLabelAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}