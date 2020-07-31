using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.Vpn;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Vpn.Vpn
{
    public class VpnStatCommand : NitroCommand<VpnStatResponse>
    {
        public VpnStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}