using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingGslbService
{
    public class ServerBindingGslbServiceGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/server_gslbservice_binding";
        public override INitroRequestOptions Options { get; set; } = new ServerBindingGslbServiceGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ServerBindingGslbServiceGetRequestDataRoot();
    }
}