using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer
{
    public class VServerRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/vserver";
        public override INitroRequestDataRoot DataRoot => new VServerRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new VServerRemoveRequestOptions();
    }
}