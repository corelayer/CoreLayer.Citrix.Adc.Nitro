using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverUpdateCommand : NitroCommand
    {
        public LbvserverUpdateCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration)
        {
            
        }
    }
}