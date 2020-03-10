using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile
{
    public class SystemFileRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestDataRoot DataRoot => new SystemFileRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemFileRemoveRequestOptions(null);
    }
}