using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile
{
    public class SystemFileGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestDataRoot DataRoot => new SystemFileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemFileGetRequestOptions();
        
    }
}