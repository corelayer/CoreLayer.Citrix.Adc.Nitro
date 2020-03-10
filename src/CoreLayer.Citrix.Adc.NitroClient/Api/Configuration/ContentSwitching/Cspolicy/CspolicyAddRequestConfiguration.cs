using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/cspolicy";
        public override INitroRequestOptions Options => new CspolicyAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CspolicyAddRequestConfiguration(CspolicyAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}