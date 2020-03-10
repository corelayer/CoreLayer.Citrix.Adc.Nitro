using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/cspolicy";
        public override INitroRequestDataRoot DataRoot => new CspolicyGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CspolicyGetRequestOptions();
    }
}