using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.InatSession;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.InatSession
{
    public class InatSessionStatCommand : NitroCommand<InatSessionStatResponse>
    {
        public InatSessionStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}