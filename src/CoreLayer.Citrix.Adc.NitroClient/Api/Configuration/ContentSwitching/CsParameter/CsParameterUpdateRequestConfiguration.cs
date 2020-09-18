using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csparameter";
        public override INitroRequestOptions Options => new CsParameterUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsParameterUpdateRequestConfiguration(CsParameterUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}