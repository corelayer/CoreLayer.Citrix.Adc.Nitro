using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/csaction";
        public override INitroRequestOptions Options => new CsactionAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsactionAddRequestConfiguration(CsactionAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}