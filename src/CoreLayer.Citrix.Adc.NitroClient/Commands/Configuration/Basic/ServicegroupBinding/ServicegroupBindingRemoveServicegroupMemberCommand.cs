using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveServicegroupMemberCommand : NitroCommand
    {
        public ServicegroupBindingRemoveServicegroupMemberCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) : base(httpClient, requestConfiguration)
        {
            
        }
    }
}