using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/csparameter";
        public override INitroRequestDataRoot DataRoot => new CsParameterGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsParameterGetRequestOptions();
    }
}