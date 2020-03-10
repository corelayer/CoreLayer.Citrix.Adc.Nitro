using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetServicegroupMemberCommand : NitroCommand
    {
        public ServicegroupBindingGetServicegroupMemberCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) : base(httpClient, requestConfiguration)
        {
            
        }
    }
}