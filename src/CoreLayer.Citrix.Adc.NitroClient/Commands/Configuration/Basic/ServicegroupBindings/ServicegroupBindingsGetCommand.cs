using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBindings;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServicegroupBindings
{
    public class ServicegroupBindingsGetCommand : NitroCommand<ServicegroupBindingsGetResponse>
    {
        public ServicegroupBindingsGetCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}