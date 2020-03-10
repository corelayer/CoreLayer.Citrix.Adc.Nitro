using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/cspolicy";
        public override INitroRequestOptions Options => new CspolicyUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CspolicyUpdateRequestConfiguration(CspolicyUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}