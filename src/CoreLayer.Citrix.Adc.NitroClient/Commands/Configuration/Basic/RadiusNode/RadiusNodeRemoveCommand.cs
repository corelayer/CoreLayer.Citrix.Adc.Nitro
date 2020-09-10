using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.RadiusNode
{
    public class RadiusNodeRemoveCommand : NitroCommand<RadiusNodeRemoveResponse>
    {
        public RadiusNodeRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}