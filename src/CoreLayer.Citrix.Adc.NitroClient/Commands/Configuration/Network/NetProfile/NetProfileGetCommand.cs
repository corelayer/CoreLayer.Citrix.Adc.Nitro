using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Network.NetProfile
{
    public class NetProfileGetCommand : NitroCommand
    {
        public NetProfileGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(
            httpClient, requestConfiguration)
        {
            
        }
    }
}