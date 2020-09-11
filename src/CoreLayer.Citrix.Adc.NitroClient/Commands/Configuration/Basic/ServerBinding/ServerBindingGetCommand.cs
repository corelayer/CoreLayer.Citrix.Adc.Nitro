using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServerBinding
{
    public class ServerBindingGetCommand : NitroCommand<ServerBindingGetResponse>
    {
        public ServerBindingGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            :base(serviceClient, requestConfiguration){}
    }
}