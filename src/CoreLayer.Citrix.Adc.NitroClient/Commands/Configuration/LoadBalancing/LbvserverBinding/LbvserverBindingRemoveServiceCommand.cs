using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingRemoveServiceCommand : NitroCommand
    {
        public LbvserverBindingRemoveServiceCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            : base(httpClient, requestConfiguration) { }
    }
}