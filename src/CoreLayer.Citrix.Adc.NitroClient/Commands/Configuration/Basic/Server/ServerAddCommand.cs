using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Server
{
    public class ServerAddCommand : NitroCommand
    {
        public ServerAddCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) 
            :base(httpClient, requestConfiguration){}
    }
}