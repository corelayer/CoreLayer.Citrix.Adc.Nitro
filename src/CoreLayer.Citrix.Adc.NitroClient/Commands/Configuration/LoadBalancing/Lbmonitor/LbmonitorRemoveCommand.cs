using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorRemoveCommand : NitroCommand
    {
        public LbmonitorRemoveCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            : base(httpClient, requestConfiguration){ }
    }
}