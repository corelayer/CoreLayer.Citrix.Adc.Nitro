using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUnsetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/cspolicy";
        public override INitroRequestDataRoot DataRoot { get; }
        public override INitroRequestOptions Options => new CspolicyUnsetRequestOptions(){Action = "unset"};
                
        public CspolicyUnsetRequestConfiguration(CspolicyUnsetRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}