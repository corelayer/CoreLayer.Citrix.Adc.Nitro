using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveServicegroupMemberRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/servicegroup_servicegroupmember_binding";
        public override INitroRequestDataRoot DataRoot => new ServicegroupBindingRemoveServicegroupMemberRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupBindingRemoveServicegroupMemberRequestOptions();
    }
}