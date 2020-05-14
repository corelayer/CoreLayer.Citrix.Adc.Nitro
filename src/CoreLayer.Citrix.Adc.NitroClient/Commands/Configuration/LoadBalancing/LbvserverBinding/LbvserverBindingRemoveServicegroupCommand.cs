using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingRemoveServicegroupCommand : NitroCommand<LbvserverBindingRemoveResponse>
    {
        public LbvserverBindingRemoveServicegroupCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}