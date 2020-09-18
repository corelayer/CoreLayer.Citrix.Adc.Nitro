using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionRenameRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/csaction";
        public override INitroRequestDataRoot DataRoot { get; }
        public override INitroRequestOptions Options => new CsactionRenameRequestOptions(){Action = "rename"};
                
        public CsactionRenameRequestConfiguration(CsactionRenameRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}