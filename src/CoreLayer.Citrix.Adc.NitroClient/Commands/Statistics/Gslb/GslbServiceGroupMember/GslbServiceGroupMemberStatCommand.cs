using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbServiceGroupMember;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Gslb.GslbServiceGroupMember
{
    public class GslbServiceGroupMemberStatCommand : NitroCommand<GslbServiceGroupMemberStatResponse>
    {
        public GslbServiceGroupMemberStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}