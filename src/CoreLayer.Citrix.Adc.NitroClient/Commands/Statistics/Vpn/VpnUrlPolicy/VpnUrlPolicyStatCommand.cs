using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.VpnUrlPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Vpn.VpnUrlPolicy
{
    public class VpnUrlPolicyStatCommand : NitroCommand<VpnUrlPolicyStatResponse>
    {
        public VpnUrlPolicyStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}