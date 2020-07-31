using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbServiceGroup;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Gslb.GslbServiceGroup
{
    public class GslbServiceGroupStatCommand : NitroCommand<GslbServiceGroupStatResponse>
    {
        public GslbServiceGroupStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
                                                 
        }
    }
}