using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNatIp;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.RNatIp
{
    public class RNatIpStatCommand : NitroCommand<RNatIpStatResponse>
    {
        public RNatIpStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}