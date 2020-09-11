using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingService
{
    public class ServerBindingServiceGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/server_service_binding";
        public override INitroRequestOptions Options { get; set; } = new ServerBindingServiceGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ServerBindingServiceGetRequestDataRoot();
    }
}