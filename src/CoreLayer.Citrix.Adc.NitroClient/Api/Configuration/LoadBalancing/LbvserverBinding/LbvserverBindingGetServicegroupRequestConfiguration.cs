using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetServicegroupRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/lbvserver_servicegroup_binding";
        public override INitroRequestDataRoot DataRoot => new LbvserverBindingGetServicegroupRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new LbvserverBindingGetServicegroupRequestOptions();
    }
}