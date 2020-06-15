using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Interface;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.Interface
{
    public class InterfaceStatCommand : NitroCommand<InterfaceStatResponse>
    {
        public InterfaceStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}