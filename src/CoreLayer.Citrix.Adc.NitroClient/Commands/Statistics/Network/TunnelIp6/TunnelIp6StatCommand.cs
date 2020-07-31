using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.TunnelIp6;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.TunnelIp6
{
    public class TunnelIp6StatCommand : NitroCommand<TunnelIp6StatResponse>
    {
        public TunnelIp6StatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}