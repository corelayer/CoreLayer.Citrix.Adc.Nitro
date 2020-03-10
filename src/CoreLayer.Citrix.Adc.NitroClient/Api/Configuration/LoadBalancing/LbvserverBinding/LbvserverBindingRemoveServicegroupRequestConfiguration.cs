using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingRemoveServicegroupRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/lbvserver_servicegroup_binding";
        public override INitroRequestDataRoot DataRoot => new LbvserverBindingRemoveServicegroupRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LbvserverBindingRemoveServicegroupRequestOptions();
    }
}