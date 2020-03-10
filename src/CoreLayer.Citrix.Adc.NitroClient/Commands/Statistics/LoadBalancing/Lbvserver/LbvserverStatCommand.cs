using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.LoadBalancing.Lbvserver
{
    public class LbvserverStatCommand: NitroCommand
    {
        public LbvserverStatCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : 
            base(httpClient, requestConfiguration) { }
    }
}