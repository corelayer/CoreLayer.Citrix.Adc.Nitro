using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbService;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Gslb.GslbService
{
    public class GslbServiceStatCommand : NitroCommand<GslbServiceStatResponse>
    {
        public GslbServiceStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
                                                 
        }
    }
}