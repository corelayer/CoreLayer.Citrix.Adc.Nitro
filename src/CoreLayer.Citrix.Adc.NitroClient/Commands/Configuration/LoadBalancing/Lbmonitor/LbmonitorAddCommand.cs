using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorAddCommand : NitroCommand<LbmonitorAddResponse>
    {
        public LbmonitorAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration) { }
    }
}