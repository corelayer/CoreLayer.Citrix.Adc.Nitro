using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.RadiusNode
{
    public class RadiusNodeGetCommand : NitroCommand<RadiusNodeGetResponse>
    {
        public RadiusNodeGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}