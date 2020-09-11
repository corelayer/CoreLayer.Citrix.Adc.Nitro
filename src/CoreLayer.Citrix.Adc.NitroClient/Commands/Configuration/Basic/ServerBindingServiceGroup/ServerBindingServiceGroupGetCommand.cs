using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingServiceGroup;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServerBindingServiceGroup
{
    public class ServerBindingServiceGroupGetCommand : NitroCommand<ServerBindingServiceGroupGetResponse>
    {
        public ServerBindingServiceGroupGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            :base(serviceClient, requestConfiguration){}
    }
}