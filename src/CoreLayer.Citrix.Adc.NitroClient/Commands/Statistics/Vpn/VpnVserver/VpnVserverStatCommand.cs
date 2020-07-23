using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.VpnVserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Vpn.VpnVserver
{
    public class VpnVserverStatCommand : NitroCommand<VpnVserverStatResponse>
    {
        public VpnVserverStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}