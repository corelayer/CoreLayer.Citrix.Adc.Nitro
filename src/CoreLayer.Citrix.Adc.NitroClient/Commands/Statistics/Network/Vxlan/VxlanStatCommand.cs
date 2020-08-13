using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Vxlan;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.Vxlan
{
    public class VxlanStatCommand : NitroCommand<VxlanStatResponse>
    {
        public VxlanStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}