using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Network.NetProfile
{
    public class NetProfileGetCommand : NitroCommand<NetProfileGetResponse>
    {
        public NetProfileGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}