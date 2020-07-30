using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Inat;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.Inat
{
    public class InatStatCommand : NitroCommand<InatStatResponse>
    {
        public InatStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}