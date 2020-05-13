using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Network.NetProfile
{
    public class NetProfileRemoveCommand : NitroCommand<NetProfileRemoveResponse>
    {
        public NetProfileRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}