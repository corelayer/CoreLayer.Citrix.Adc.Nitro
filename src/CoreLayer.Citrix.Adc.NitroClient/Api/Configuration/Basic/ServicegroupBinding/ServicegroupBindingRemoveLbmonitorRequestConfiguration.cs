using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveLbmonitorRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/servicegroup_lbmonitor_binding";
        public override INitroRequestDataRoot DataRoot => new ServicegroupBindingRemoveLbmonitorRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupBindingRemoveLbmonitorRequestOptions();
    }
}