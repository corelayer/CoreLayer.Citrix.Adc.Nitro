using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Servicegroup
{
    public class ServicegroupRemoveCommand : NitroCommand<ServicegroupRemoveResponse>
    {
        public ServicegroupRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}