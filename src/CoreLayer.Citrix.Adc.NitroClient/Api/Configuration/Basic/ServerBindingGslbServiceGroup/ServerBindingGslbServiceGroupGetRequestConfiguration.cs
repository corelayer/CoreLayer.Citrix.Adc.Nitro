using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingGslbServiceGroup
{
    public class ServerBindingGslbServiceGroupGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/server_gslbservicegroup_binding";
        public override INitroRequestOptions Options { get; set; } = new ServerBindingGslbServiceGroupGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ServerBindingGslbServiceGroupGetRequestDataRoot();
    }
}