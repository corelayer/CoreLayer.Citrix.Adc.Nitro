using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingServiceGroup
{
    public class ServerBindingServiceGroupGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/server_servicegroup_binding";
        public override INitroRequestOptions Options { get; set; } = new ServerBindingServiceGroupGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ServerBindingServiceGroupGetRequestDataRoot();
    }
}