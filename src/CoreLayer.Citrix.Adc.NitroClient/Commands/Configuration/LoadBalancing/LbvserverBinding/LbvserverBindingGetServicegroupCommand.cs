using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetServicegroupCommand : NitroCommand<LbvserverBindingServicegroupGetResponse>
    {
        public LbvserverBindingGetServicegroupCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) : base(httpClient, requestConfiguration)
        {
            
        }
    }
}