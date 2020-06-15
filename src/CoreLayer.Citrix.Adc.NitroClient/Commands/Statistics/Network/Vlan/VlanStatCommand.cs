using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Vlan;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.Vlan
{
    public class VlanStatCommand : NitroCommand<VlanStatResponse>
    {
        public VlanStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}