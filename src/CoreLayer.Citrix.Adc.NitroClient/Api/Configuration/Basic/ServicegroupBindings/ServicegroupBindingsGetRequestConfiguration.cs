using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBindings
{
    public class ServicegroupBindingsGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/servicegroupbindings";
        public override INitroRequestDataRoot DataRoot => new ServicegroupBindingsGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupBindingsGetRequestOptions("");
    }
}