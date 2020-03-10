using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetServicegroupMemberRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/servicegroup_servicegroupmember_binding";
        public override INitroRequestDataRoot DataRoot => new ServicegroupBindingGetServicegroupMemberRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupBindingGetServicegroupMemberRequestOptions();
    }
}