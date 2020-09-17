using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelRenameRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/cspolicylabel";
        public override INitroRequestDataRoot DataRoot { get; }
        public override INitroRequestOptions Options => new CsPolicyLabelRenameRequestOptions(){Action = "rename"};
                
        public CsPolicyLabelRenameRequestConfiguration(CsPolicyLabelRenameRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}