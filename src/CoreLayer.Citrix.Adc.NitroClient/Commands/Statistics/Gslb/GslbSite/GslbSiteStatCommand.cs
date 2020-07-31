using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbSite;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Gslb.GslbSite
{
    public class GslbSiteStatCommand : NitroCommand<GslbSiteStatResponse>
    {
        public GslbSiteStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}