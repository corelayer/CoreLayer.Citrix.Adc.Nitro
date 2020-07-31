using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.TunnelIp;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.TunnelIp
{
    public class TunnelIpStatCommand : NitroCommand<TunnelIpStatResponse>
    {
        public TunnelIpStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}