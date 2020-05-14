using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveServicegroupMemberCommand : NitroCommand<ServicegroupBindingRemoveResponse>
    {
        public ServicegroupBindingRemoveServicegroupMemberCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}