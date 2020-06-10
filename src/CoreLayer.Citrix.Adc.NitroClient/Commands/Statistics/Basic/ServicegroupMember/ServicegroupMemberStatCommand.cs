using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.ServicegroupMember;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Basic.ServicegroupMember
{
    public class ServicegroupMemberStatCommand : NitroCommand<ServicegroupMemberStatResponse>
    {
        public ServicegroupMemberStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}