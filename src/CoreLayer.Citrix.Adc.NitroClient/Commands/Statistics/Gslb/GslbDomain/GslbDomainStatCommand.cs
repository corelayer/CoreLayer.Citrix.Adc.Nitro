using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbDomain;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Gslb.GslbDomain
{
    public class GslbDomainStatCommand : NitroCommand<GslbDomainStatResponse>
    {
        public GslbDomainStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}