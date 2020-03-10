using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csaction";
        public override INitroRequestOptions Options => new CsactionUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsactionUpdateRequestConfiguration(CsactionUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}