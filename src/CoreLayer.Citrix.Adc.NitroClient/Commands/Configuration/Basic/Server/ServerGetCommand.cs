using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Server
{
    public class ServerGetCommand : NitroCommand<ServerGetResponse>
    {
        public ServerGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            :base(serviceClient, requestConfiguration){}
    }
}