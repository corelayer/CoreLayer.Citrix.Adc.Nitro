using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Server
{
    public class ServerRemoveCommand : NitroCommand
    {
        public ServerRemoveCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            : base(httpClient, requestConfiguration) { }
    }
}