using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Bridge;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.Bridge
{
    public class BridgeStatCommand : NitroCommand<BridgeStatResponse>
    {
        public BridgeStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}