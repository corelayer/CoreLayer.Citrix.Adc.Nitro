using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorGetCommand : NitroCommand
    {
        public LbmonitorGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) 
            :base(httpClient, requestConfiguration) { }
    }
}