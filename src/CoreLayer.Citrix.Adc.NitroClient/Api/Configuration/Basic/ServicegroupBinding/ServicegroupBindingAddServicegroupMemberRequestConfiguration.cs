using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddServicegroupMemberRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/servicegroup_servicegroupmember_binding";
        public override INitroRequestOptions Options => new ServicegroupBindingAddServicegroupMemberRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServicegroupBindingAddServicegroupMemberRequestConfiguration(
            ServicegroupBindingAddServicegroupMemberRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}