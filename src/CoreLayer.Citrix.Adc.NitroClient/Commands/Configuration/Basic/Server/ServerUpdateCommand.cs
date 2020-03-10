using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Server
{
    public class ServerUpdateCommand : NitroCommand
    {
        public ServerUpdateCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(httpClient,
            requestConfiguration)
        {
            
        }
    }
}