using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServicegroupCommand : NitroCommand
    {
        public LbvserverBindingAddServicegroupCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) : base(httpClient, requestConfiguration)
        {
            
        }
    }
}