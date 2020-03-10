using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csaction";
        public override INitroRequestDataRoot DataRoot => new CsactionRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsactionRemoveRequestOptions();
    }
}