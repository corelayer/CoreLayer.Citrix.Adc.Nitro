using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Server
{
    public class ServerGetCommand : NitroCommand
    {
        public ServerGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            :base(httpClient, requestConfiguration){}
    }
}