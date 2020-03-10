using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorAddCommand : NitroCommand
    {
        public LbmonitorAddCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) 
            :base(httpClient, requestConfiguration) { }
    }
}