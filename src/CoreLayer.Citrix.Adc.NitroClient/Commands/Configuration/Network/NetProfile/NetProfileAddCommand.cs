using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Network.NetProfile
{
    public class NetProfileAddCommand : NitroCommand<NetProfileAddResponse>
    {
        public NetProfileAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}