using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbVserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Gslb.GslbVserver
{
    public class GslbVserverStatCommand : NitroCommand<GslbVserverStatResponse>
    {
        public GslbVserverStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}