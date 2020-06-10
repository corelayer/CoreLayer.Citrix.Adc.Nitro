using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.ServicegroupMember
{
    public class ServicegroupMemberStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/servicegroupmember";
        public override INitroRequestDataRoot DataRoot => new ServicegroupMemberStatRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupMemberStatRequestOptions();
    }
}