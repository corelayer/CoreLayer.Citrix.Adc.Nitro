using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingGslbService;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServerBindingGslbService
{
    public class ServerBindingGslbServiceGetCommand : NitroCommand<ServerBindingGslbServiceGetResponse>
    {
        public ServerBindingGslbServiceGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            :base(serviceClient, requestConfiguration){}
    }
}