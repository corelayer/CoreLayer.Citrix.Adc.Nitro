using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServiceRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/lbvserver_service_binding";
        public override INitroRequestOptions Options => new LbvserverBindingAddServiceRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public LbvserverBindingAddServiceRequestConfiguration(LbvserverBindingAddServiceRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}