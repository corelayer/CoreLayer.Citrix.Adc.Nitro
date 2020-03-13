using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.LoadBalancing.Lbvserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.LoadBalancing.Lbvserver
{
    public class LbvserverStatCommand: NitroCommand<LbvserverStatResponse>
    {
        public LbvserverStatCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : 
            base(httpClient, requestConfiguration) { }
    }
}