using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/server";
        public override INitroRequestDataRoot DataRoot => new ServerRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServerRemoveRequestOptions();
    }
}