using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveLbmonitorCommand : NitroCommand<ServicegroupBindingRemoveResponse>
    {
        public ServicegroupBindingRemoveLbmonitorCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            : base(serviceClient, requestConfiguration) { }
    }
}