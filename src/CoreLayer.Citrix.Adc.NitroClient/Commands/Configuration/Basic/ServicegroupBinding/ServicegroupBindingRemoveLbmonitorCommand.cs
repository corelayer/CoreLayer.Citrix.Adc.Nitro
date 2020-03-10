using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveLbmonitorCommand : NitroCommand
    {
        public ServicegroupBindingRemoveLbmonitorCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) 
            : base(httpClient, requestConfiguration) { }
    }
}