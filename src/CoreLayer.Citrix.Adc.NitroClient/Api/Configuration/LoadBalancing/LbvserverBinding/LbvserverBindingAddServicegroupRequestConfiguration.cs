using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServicegroupRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/lbvserver_servicegroup_binding";
        public override INitroRequestOptions Options => new LbvserverBindingAddServicegroupRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public LbvserverBindingAddServicegroupRequestConfiguration(LbvserverBindingAddServicegroupRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}