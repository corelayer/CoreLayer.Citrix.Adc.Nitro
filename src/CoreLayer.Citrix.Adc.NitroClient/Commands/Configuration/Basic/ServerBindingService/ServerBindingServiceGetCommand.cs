using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingService;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServerBindingService
{
    public class ServerBindingServiceGetCommand : NitroCommand<ServerBindingServiceGetResponse>
    {
        public ServerBindingServiceGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            :base(serviceClient, requestConfiguration){}
    }
}