using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveLbmonitorCommand : NitroCommand<NitroResponse>
    {
        public ServicegroupBindingRemoveLbmonitorCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            : base(serviceClient, requestConfiguration) { }
    }
}